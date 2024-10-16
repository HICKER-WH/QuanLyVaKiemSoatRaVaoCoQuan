using AForge.Video;
using AForge.Video.DirectShow;
using Project01.Controls;
using Project01.Models;
using QRCoder;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using ZXing;
using static Project01.eNum.enumSW;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace Project01.FrmChild
{
  public partial class AddEmployeeFrm : Form
  {
    public delegate void SendReloadData();
    public event SendReloadData OnSendReloadData;

    private eTypeButton _eTypeButton;
    private Employee _employee;
    public AddEmployeeFrm(eTypeButton eTypeButton, Employee employee)
    {
      InitializeComponent();

      _eTypeButton = eTypeButton;
      _employee = employee;

      btnUpdate.Visible = eTypeButton == eTypeButton.Edit;
      btnAdd.Visible = eTypeButton == eTypeButton.Add;
    }


    private SoundPlayer soundPlayer;
    private FilterInfoCollection _filterInfoCollection;
    private VideoCaptureDevice _videoCaptureDevice;

    private void AddEmployeeFrm_Load(object sender, EventArgs e)
    {
      soundPlayer = new SoundPlayer(Properties.Resources.beep);

      // Khởi tạo danh sách các camera
      _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
      cbbCamera.Items.Clear();

      foreach (FilterInfo device in _filterInfoCollection)
      {
        cbbCamera.Items.Add(device.Name);
      }

      //Load phân loại nhân viên
      if (AppCore.Ins._typeEmployees != null)
      {
        cbbTypeEmployee.DataSource = AppCore.Ins._typeEmployees.Select(x => x.NameType).ToList();
      }

      if (_employee != null)
      {
        txtName.Text = _employee.FullName;
        txtCCCD.Text = _employee.CCCD.ToString();
        txtPhone.Text = _employee.Phone;
        txtSerialcode.Text = _employee.SerialCode;
        cbbTypeEmployee.SelectedItem = _employee.TypeEmployee.NameType;
        FrmHome.Instance.ShowImage(picImageEmployee, _employee.PathImage);
      }
    }



    private void btnActionCamera_Click(object sender, EventArgs e)
    {
      if (btnActionCamera.Text.Trim() == "Open")
      {
        try
        {
          _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);
          _videoCaptureDevice.NewFrame += _videoCaptureDevice_NewFrame;
          _videoCaptureDevice.Start();
          btnActionCamera.Text = "Close";
        }
        catch (Exception)
        {

        }
      }
      else
      {
        CheckCloseCamera();
        btnActionCamera.Text = "Open";
      }
    }

    private void _videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
    {
      Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
      BarcodeReader barcodeReader = new BarcodeReader();
      var rs = barcodeReader.Decode(bitmap);

      if (rs != null)
      {
        ReceidData(rs.ToString());
      }

      pictureBox1.Image = bitmap;
    }

    private void CheckCloseCamera()
    {
      if (_videoCaptureDevice != null)
      {
        if (_videoCaptureDevice.IsRunning)
        {
          _videoCaptureDevice.Stop();
          pictureBox1.Image = null;
        }
      }
    }


    private async void btnAdd_Click(object sender, EventArgs e)
    {
      var exits = AppCore.Ins._employees.Any(x => x.SerialCode == txtSerialcode.Text && x.IsDelete == false);
      if (exits)
      {
        MessageBox.Show("Mã QR hoặc Barcode đã tồn tại. Vui lòng chọn mã khác !");
        return;
      }

      long cccdId = 0;
      if (string.IsNullOrEmpty(txtName.Text))
      {
        MessageBox.Show("Tên không được để trống !");
        return;
      }
      if (!long.TryParse(txtPhone.Text, out cccdId))
      {
        MessageBox.Show("Định dạng số điện thoại không đúng !");
        return;
      }
      if (!long.TryParse(txtCCCD.Text, out cccdId))
      {
        MessageBox.Show("Định dạng CCCD không đúng !");
        return;
      }

      if (cbbTypeEmployee.SelectedIndex == -1)
      {
        MessageBox.Show("Vui lòng chọn phân nhóm nhân viên !");
        return;
      }

      var typeEmployee = AppCore.Ins._typeEmployees.Where(x => x.NameType == cbbTypeEmployee.SelectedItem.ToString()).FirstOrDefault();
      if (typeEmployee == null)
      {
        MessageBox.Show("Không tìm thấy phân loại nhân viên !");
        return;
      }

      string fileNameImage = "";
      if (selectedImage != null)
      {
        fileNameImage = AppCore.Ins.pathFolderImage + $"\\Image{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
        selectedImage.Save(fileNameImage);
      }

      Employee employee = new Employee()
      {
        FullName = txtName.Text,
        CCCD = txtCCCD.Text,
        Phone = txtPhone.Text,
        SerialCode = txtSerialcode.Text,
        PathImage = fileNameImage,
        TypeEmployeeId = typeEmployee.Id,
      };

      await AppCore.Ins.AddEmployee(employee);

      ResetForm();

      OnSendReloadData?.Invoke();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ResetForm()
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          ResetForm();
        }));
        return;
      }

      txtName.Text = string.Empty;
      txtCCCD.Text = string.Empty;
      txtPhone.Text = string.Empty;
      txtSerialcode.Text = string.Empty;
      cbbTypeEmployee.SelectedIndex = -1;
      picImageEmployee.Image = Properties.Resources.ImageEmployeeDefault;
    }

    private void ReceidData(string data)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          ReceidData(data);
        }));
        return;
      }

      this.txtSerialcode.Text = data.ToString();
      soundPlayer.Play();
    }

    private void txtSerialcode_TextChanged(object sender, EventArgs e)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          txtSerialcode_TextChanged(sender, e);
        }));
        return;
      }
      if (string.IsNullOrEmpty(this.txtSerialcode.Text)) return;
      GenerateQRCode(this.txtSerialcode.Text);
      GenerateBarcode(this.txtSerialcode.Text);
    }


    private Bitmap qrCodeImage;
    private void GenerateQRCode(string text)
    {
      try
      {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
          using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q))
          {
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
              qrCodeImage = qrCode.GetGraphic(20);
              picQR.Image = qrCodeImage;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi: {ex.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private Bitmap barcodeBitmap;
    private void GenerateBarcode(string text)
    {
      try
      {
        BarcodeWriter barcodeWriter = new BarcodeWriter
        {
          Format = BarcodeFormat.CODE_128,
          Options = new ZXing.Common.EncodingOptions
          {
            Width = 300,
            Height = 150
          }
        };
        barcodeBitmap = barcodeWriter.Write(text);
        //picBarcode.Image = barcodeBitmap;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi: {ex.ToString()}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void btnBarcodeDownload_Click(object sender, EventArgs e)
    {
      if (barcodeBitmap != null)
      {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
          saveFileDialog.Title = "Save Barcode Image";
          saveFileDialog.FileName = $"Barcode{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";

          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            barcodeBitmap.Save(saveFileDialog.FileName);
            MessageBox.Show("Ảnh lưu thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      else
      {
        MessageBox.Show("Không tìm thấy Barcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnQRDownload_Click(object sender, EventArgs e)
    {
      if (qrCodeImage != null)
      {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
          saveFileDialog.Title = "Save QR code Image";
          saveFileDialog.FileName = $"QRcode{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";

          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            qrCodeImage.Save(saveFileDialog.FileName);
            MessageBox.Show("Ảnh lưu thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      else
      {
        MessageBox.Show("Không tìm thấy QR code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private Image selectedImage;
    private void btnChooseImage_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files|*.*";
        openFileDialog.Title = "Chọn Ảnh";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          selectedImage = Image.FromFile(openFileDialog.FileName);
          picImageEmployee.Image = selectedImage;
        }
      }
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      var exits = AppCore.Ins._employees.Any(x => x.SerialCode == txtSerialcode.Text && x.Id != _employee.Id);
      if (exits)
      {
        MessageBox.Show("Mã QR hoặc Barcode đã tồn tại. Vui lòng chọn mã khác !");
        return;
      }

      if (string.IsNullOrEmpty(txtName.Text))
      {
        MessageBox.Show("Tên không được để trống !");
        return;
      }
      long cccdId = 0;
      if (!long.TryParse(txtPhone.Text, out cccdId))
      {
        MessageBox.Show("Định dạng số điện thoại không đúng !");
        return;
      }
      if (!long.TryParse(txtCCCD.Text, out cccdId))
      {
        MessageBox.Show("Định dạng CCCD không đúng !");
        return;
      }

      if (cbbTypeEmployee.SelectedIndex == -1)
      {
        MessageBox.Show("Vui lòng chọn phân nhóm nhân viên !");
        return;
      }

      var typeEmployee = AppCore.Ins._typeEmployees.Where(x => x.NameType == cbbTypeEmployee.SelectedItem.ToString()).FirstOrDefault();
      if (typeEmployee == null)
      {
        MessageBox.Show("Không tìm thấy phân loại nhân viên !");
        return;
      }

      if (selectedImage != null)
      {
        string fileNameImage = AppCore.Ins.pathFolderImage + $"\\Image{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
        selectedImage.Save(fileNameImage);
        _employee.PathImage = fileNameImage;
      }

      try
      {
				_employee.FullName = txtName.Text;
				_employee.CCCD = txtCCCD.Text;
				_employee.Phone = txtPhone.Text;
				_employee.SerialCode = txtSerialcode.Text;
				_employee.TypeEmployeeId = typeEmployee.Id;
				_employee.TypeEmployee = typeEmployee;

				_employee.UpdatedAt = DateTime.Now;

				await AppCore.Ins.UpdateEmployee(_employee);
			}
      catch (Exception ex)
      {

      }
      

      OnSendReloadData?.Invoke();

      this.Close();
    }

    private void AddEmployeeFrm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (_videoCaptureDevice != null)
      {
        _videoCaptureDevice.NewFrame -= _videoCaptureDevice_NewFrame;
        CheckCloseCamera();
      }

    }

		private void cbbTypeEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}
	}
}

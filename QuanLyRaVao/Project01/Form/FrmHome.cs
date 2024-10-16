using AForge.Video;
using AForge.Video.DirectShow;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Wordprocessing;
using Project01.Controls;
using Project01.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using ZXing;
using static Project01.eNum.enumSW;
using Color = System.Drawing.Color;
using DateTime = System.DateTime;

namespace Project01.FrmChild
{
  public partial class FrmHome : Form
  {
    public FrmHome()
    {
      InitializeComponent();
      this.Load += FrmHome_Load;
      this.Shown += FrmHome_Shown;
    }

    private SoundPlayer soundPlayer;
    private FilterInfoCollection _filterInfoCollection;
    private VideoCaptureDevice _videoCaptureDevice;

    #region Singleton parttern
    private static FrmHome _Instance = null;
    public static FrmHome Instance
    {
      get
      {
        if (_Instance == null)
        {
          _Instance = new FrmHome();
        }
        return _Instance;
      }
    }
    #endregion

    private Color ColorDefault = Color.FromArgb(102, 204, 255);
    private Color ColorRun = Color.DarkGreen;
    private Color ColorStop = Color.Maroon;
    private Random rd = new Random();

    private void FrmHome_Load(object sender, EventArgs e)
    {
      LoadColumDgv();
    }

    
    private void FrmHome_Shown(object sender, EventArgs e)
    {
      //thư viện bật tiếng
      soundPlayer = new SoundPlayer(Properties.Resources.beep);

      // Khởi tạo danh sách các camera
      _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
      cbbCamera.Items.Clear();
      foreach (FilterInfo device in _filterInfoCollection)
      {
        cbbCamera.Items.Add(device.Name);
      }

      LoadDataOld();
    }

  

    private void LoadColumDgv()
    {
      dgv.Columns.Clear();

      // Tạo cột mới
      DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
      column1.HeaderText = "STT";
      column1.Name = "Column1";
      column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

      DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
      column2.HeaderText = "Họ & Tên";
      column2.Name = "Column2";
      //column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


      DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
      column3.HeaderText = "CCCD";
      column3.Name = "Column3";
      column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

      DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
      column4.HeaderText = "Số điện thoại";
      column4.Name = "Column4";
      column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

      DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
      column5.HeaderText = "Phân loại";
      column5.Name = "Column5";
      column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

      DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
      column6.HeaderText = "Trạng thái";
      column6.Name = "Column6";
      column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

      DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
      column7.HeaderText = "Thời gian";
      column7.Name = "Column7";
      column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

      // Thêm cột vào DataGridView
      dgv.Columns.Add(column1);
      dgv.Columns.Add(column2);
      dgv.Columns.Add(column3);
      dgv.Columns.Add(column4);
      dgv.Columns.Add(column5);
      dgv.Columns.Add(column6);
      dgv.Columns.Add(column7);
    }

    private void LoadDataOld()
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          LoadDataOld();
        }));

        return;
      }

      if (AppCore.Ins._listDataOld.Count > 0)
      {
        var dataLoad = AppCore.Ins._listDataOld.AsEnumerable().Reverse().ToList();
        foreach (var item in dataLoad)
        {
          var employee = AppCore.Ins._employees.Where(x => x.Id == item.EmployeeId).FirstOrDefault();
          eStatus eStatus = item.eStatus;
          AddDatalogToDgv(employee, eStatus, item.CreatedAt);
        }

      }
    }

    private void btnActionCamera_Click(object sender, EventArgs e)
    {
      try
      {
        //Thư viện đọc hình ảnh
        if (btnActionCamera.Text.Trim() == "Open")
        {
          _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbbCamera.SelectedIndex].MonikerString);
          _videoCaptureDevice.NewFrame += _videoCaptureDevice_NewFrame;
          _videoCaptureDevice.Start();
          btnActionCamera.Text = "Close";
        }
        else
        {
          CheckCloseCamera();
          btnActionCamera.Text = "Open";
        }
      }
      catch (Exception)
      {

      }
    }


    public TimeSpan timeReceipData = TimeSpan.FromSeconds(1);
    private DateTime lastTimeReceipData;
    private void _videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
    {
      TimeSpan difference = DateTime.Now.Subtract(lastTimeReceipData);
      Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
      BarcodeReader barcodeReader = new BarcodeReader();
      var rs = barcodeReader.Decode(bitmap);

      if (rs != null)
      {
        //Xử lý
        if (difference >= timeReceipData)
        {
          ProcessingData(rs.ToString());
          lastTimeReceipData = DateTime.Now;
        }
      }

      pictureBox1.Image = bitmap;
    }
    public void CheckCloseCamera()
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


    private Employee employeePrevious = new Employee();
    private DateTime lastTime;
    public TimeSpan scanCooldown = TimeSpan.FromSeconds(AppCore.Ins._secondReceidData);

    private async void ProcessingData(string data)
    {
      var employee = AppCore.Ins._employees.Where(XLParser => XLParser.SerialCode == data && XLParser.IsDelete == false).FirstOrDefault();
      if (employee != null)
      {
        //Check lập lại
        TimeSpan difference = DateTime.Now.Subtract(lastTime);
        if (employee.Id == employeePrevious.Id && difference < scanCooldown)
        {
          //Nothing
        }  
        else
        {
          eStatus eStatus = await AppCore.Ins.CheckStatus(employee.Id);
          Datalog datalog = new Datalog()
          {
            EmployeeId = employee.Id,
            eStatus = eStatus,
          };

          var rs = await AppCore.Ins.AddDatalog(datalog);

          if (rs)
          {
            AddDatalogToDgv(employee, eStatus, datalog.CreatedAt);

            employeePrevious = employee;
            lastTime = DateTime.Now;
            soundPlayer.Play();

            if (eStatus == eStatus.CheckIn)
            {
              AppCore.Ins.SendSerrial(Properties.Settings.Default.OutputDataStrCheckIn);
            }  
            else if (eStatus == eStatus.CheckOut)
            {
              AppCore.Ins.SendSerrial(Properties.Settings.Default.OutputDataStrCheckOut);
            }  
          }
          else
          {
            //Lưu thất bại
            AppCore.Ins.SendSerrial(Properties.Settings.Default.OutputDataStrCheckNG);
          }  
        }
      }
      else
      {
        //Không tìm thấy
        AppCore.Ins.SendSerrial(Properties.Settings.Default.OutputDataStrCheckNG);
      }  

    }

    private long stt = 0;
    private void AddDatalogToDgv(Employee employee, eStatus eStatus, DateTime dateTime)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          AddDatalogToDgv(employee, eStatus, dateTime);
        }));
        return;
      }

      stt++;
      string[] row = new string[] { $"{stt}", $"{employee.FullName}", $"{employee.CCCD}", $"{employee.Phone}", $"{employee.TypeEmployee.NameType}", eStatus.ToString(), dateTime.ToString("HH:mm:ss dd/MM/yyyy") };
      dgv.Rows.Insert(0, row);

      lbFullName.Text = employee.FullName;
      lbCCCD.Text = employee.CCCD.ToString();
      lbPhone.Text = employee.Phone;
      lbType.Text = employee.TypeEmployee.NameType;

      lbStatus.Text = eStatus == eStatus.CheckIn ? "Check in" : eStatus == eStatus.CheckOut ? "Check out" : "None";
      lbDatetime.Text = employee.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy");

      ShowImage(picImageEmployee, employee.PathImage);
    }

    public Image ShowImage(PictureBox pictureBox, string filePath)
    {
      if (this.InvokeRequired)
      {
        this.Invoke(new Action(() =>
        {
          ShowImage(pictureBox, filePath);
        }));
        return null;
      }

      if (File.Exists(filePath))
      {
        try
        {
          Image img = Image.FromFile(filePath);
          pictureBox.Image = img;
          return img;
        }
        catch (Exception )
        {
          return null;
        }
      }
      else
      {
        return null;
      }
    }




    private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
    {
      CheckCloseCamera();
    }


  }
}

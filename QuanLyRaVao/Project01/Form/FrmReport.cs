using ClosedXML.Excel;
using Project01.Controls;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01.FrmChild
{
  public partial class FrmReport : Form
  {
    public FrmReport()
    {
      InitializeComponent();
    }

    #region Singleton parttern
    private static FrmReport _Instance = null;
    public static FrmReport Instance
    {
      get
      {
        if (_Instance == null)
        {
          _Instance = new FrmReport();
        }
        return _Instance;
      }
    }
    #endregion

    private void FrmReport_Load(object sender, EventArgs e)
    {
      //Phân loại
      cbbType.Items.Clear();
      cbbType.Items.Add("Tất cả");
      var listType = AppCore.Ins._typeEmployees.Select(x => x.NameType).ToArray();
      if (listType.Count() > 0)
      {
        cbbType.Items.AddRange(listType);
      }
      cbbType.SelectedIndex = 0;

      //Trạng thái
      cbbStatus.Items.Clear();
      cbbStatus.Items.Add("Tất cả");
      cbbStatus.Items.Add("Check in");
      cbbStatus.Items.Add("Check out");
      cbbStatus.SelectedIndex = 0;
    }


    private async void btnPreview_Click(object sender, EventArgs e)
    {
      var rsOk = AppCore.Ins.CheckRole(ePermit.SeeReport);
      if (rsOk)
      {
        DateTime fileDb = dtp.Value;
        eStatus status = (eStatus)cbbStatus.SelectedIndex;
        var rs = await ResearchDatalogs(fileDb, txtSearch.Text.Trim(), status);
        dgv.DataSource = rs;
      }
      else
      {
        MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
      }
      //Test
    }


    public async Task<List<DatalogsDTO>> ResearchDatalogs(DateTime fileDb, string txtSearch, eStatus eStatus)
    {
      List<Datalog> rs = await AppCore.Ins.LoadDatalogs(fileDb);
      if (rs == null) return null;
      //Quy đổi
      List<DatalogsDTO> datalogsDTOs = new List<DatalogsDTO>();
      if (rs.Count > 0)
      {
        int stt = 1;
        foreach (var item in rs)
        {
          var employee = AppCore.Ins._employees.Where(x => x.Id == item.EmployeeId).FirstOrDefault();
          if (employee != null)
          {
            DatalogsDTO datalogsDTO = new DatalogsDTO()
            {
              STT = stt++,
              FullName = employee.FullName,
              CCCD = employee.CCCD,
              Phone = employee.Phone,
              NameType = employee.TypeEmployee.NameType,
              eStatus = item.eStatus,
              CreatedAt = item.CreatedAt,
            };
            datalogsDTOs.Add(datalogsDTO);
          }
        }
      }
      else
      {
        return datalogsDTOs;
      }

      if (cbbType.SelectedIndex > 0)
      {
        datalogsDTOs = datalogsDTOs.Where(x => x.NameType == cbbType.SelectedItem.ToString()).ToList();
      }

      if (eStatus != eStatus.All)
      {
        datalogsDTOs = datalogsDTOs.Where(x => x.eStatus == eStatus).ToList();
      }

      if (!string.IsNullOrEmpty(txtSearch))
      {
        datalogsDTOs = datalogsDTOs.Where(x =>
                                          x.FullName.ToLower().Contains(txtSearch.ToLower()) ||
                                          x.CCCD.ToString().Contains(txtSearch.ToLower()) ||
                                          x.Phone.ToLower().Contains(txtSearch.ToLower()) ||
                                          x.NameType.ToLower().Contains(txtSearch.ToLower())).ToList();
      }

      return datalogsDTOs;
    }

    private string fileName = "";
    private void btnExxport_Click(object sender, EventArgs e)
    {
      try
      {
        this.btnExport.Visible = false;

        // Load file template
        string templatePath = $@"{Application.StartupPath}\Template\FormatExcel.xlsx";
        XLWorkbook workbook = new XLWorkbook(templatePath);
        IXLWorksheet worksheet = workbook.Worksheet("Report");

        // Lấy dữ liệu từ DataGridView
        DataTable dataTable = new DataTable();
        foreach (DataGridViewColumn column in dgv.Columns)
        {
          dataTable.Columns.Add(column.HeaderText);
        }
        foreach (DataGridViewRow row in dgv.Rows)
        {
          DataRow dataRow = dataTable.NewRow();
          foreach (DataGridViewCell cell in row.Cells)
          {
            dataRow[cell.ColumnIndex] = cell.Value;
          }
          dataTable.Rows.Add(dataRow);
        }
        worksheet.Cell("A3").InsertTable(dataTable);

        using (var saveFD = new SaveFileDialog())
        {
          saveFD.Filter = "Excel|*.xlsx|All files|*.*";
          saveFD.Title = "Save report to excel file";
          saveFD.FileName = $"DataReport{dtp.Value.ToString("_dd_MM_yyyy")}";
          DialogResult dialogResult = saveFD.ShowDialog();
          if (dialogResult == DialogResult.OK) fileName = saveFD.FileName; //lay duong dan luu file
          else return; //huy report neu chon cancel
        }
        workbook.SaveAs(fileName);

        var rs = MessageBox.Show("Xuất report thành công !\n Bạn có muốn mở file bây giờ ?", "Thông báo", MessageBoxButtons.YesNo);
        if (rs==DialogResult.Yes)
        {
          try
          {
            Process.Start(fileName);
          }
          catch (Exception)
          {
          }
        }  
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        this.btnExport.Visible = true;
      }
    }

		private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

using Project01.Controls;
using Project01.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01.FrmChild
{
  public partial class ManagerEmployeeFrm : Form
  {
    public ManagerEmployeeFrm()
    {
      InitializeComponent();
    }
    #region Singleton parttern
    private static ManagerEmployeeFrm _Instance = null;
    public static ManagerEmployeeFrm Instance
    {
      get
      {
        if (_Instance == null)
        {
          _Instance = new ManagerEmployeeFrm();
        }
        return _Instance;
      }
    }
    #endregion


    private void FrmMasterData_Load(object sender, EventArgs e)
    {
      UpdateUIEmployee();
      UpdateUITypeEmployee();
    }

    private void UpdateUIEmployee()
    {
      dgvEmployees.Rows.Clear();
      if (AppCore.Ins._employees.Count <= 0) return;

      int stt = 1;
      foreach (var item in AppCore.Ins._employees)
      {
        int row = dgvEmployees.Rows.Add();
        dgvEmployees.Rows[row].Cells["C11"].Value = stt++;
        dgvEmployees.Rows[row].Cells["C12"].Value = item.FullName;
				dgvEmployees.Rows[row].Cells["C110"].Value = item.TypeEmployee.NameType;
				dgvEmployees.Rows[row].Cells["C13"].Value = item.CCCD;
        dgvEmployees.Rows[row].Cells["C14"].Value = item.Phone;
        dgvEmployees.Rows[row].Cells["C15"].Value = item.SerialCode;
        dgvEmployees.Rows[row].Cells["C16"].Value = item.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        dgvEmployees.Rows[row].Cells["C17"].Value = item.UpdatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        dgvEmployees.Rows[row].Cells["C18"].Value = "Chỉnh sửa";
        dgvEmployees.Rows[row].Cells["C19"].Value = "Xóa";
      }
			dgvEmployees.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

    private void UpdateUITypeEmployee()
    {
      dgvTypeEmployees.Rows.Clear();
      if (AppCore.Ins._typeEmployees.Count <= 0) return;

      int stt = 1;
      foreach (var item in AppCore.Ins._typeEmployees)
      {
        int row = dgvTypeEmployees.Rows.Add();
        dgvTypeEmployees.Rows[row].Cells["C21"].Value = stt++;
        dgvTypeEmployees.Rows[row].Cells["C22"].Value = item.NameType;
        dgvTypeEmployees.Rows[row].Cells["C23"].Value = item.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        dgvTypeEmployees.Rows[row].Cells["C24"].Value = item.UpdatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        dgvTypeEmployees.Rows[row].Cells["C25"].Value = "Chỉnh sửa";
        dgvTypeEmployees.Rows[row].Cells["C26"].Value = "Xóa";
      }
			dgvTypeEmployees.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void btnAdd_Click(object sender, EventArgs e)
    {
      var rsOk = AppCore.Ins.CheckRole(ePermit.AddEmployee);
      if (rsOk)
      {
        AddEmployeeFrm addEmployeeFrm = new AddEmployeeFrm(eTypeButton.Add, null);
        addEmployeeFrm.OnSendReloadData += AddEmployeeFrm_OnSendReloadData;
        addEmployeeFrm.ShowDialog();
      }
      else
      {
        MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
      }
    }

    private async void AddEmployeeFrm_OnSendReloadData()
    {
      await AppCore.Ins.ReloadEmployee();
      UpdateUIEmployee();
    }

    private void btnAddType_Click(object sender, EventArgs e)
    {
      var rsOk = AppCore.Ins.CheckRole(ePermit.AddGroupTypeEmployee);
      if (rsOk)
      {
        AddTypeEmployeeFrm addTypeFrm = new AddTypeEmployeeFrm(eTypeButton.Add, null);
        addTypeFrm.OnSendReloadData += AddTypeFrm_OnSendReloadData;
        addTypeFrm.ShowDialog();
      }
      else
      {
        MessageBox.Show("Bạ không có phân quyền thực hiện hành động này !");
      }

    }

    private async void AddTypeFrm_OnSendReloadData()
    {
      await AppCore.Ins.ReloadEmployee();
      UpdateUITypeEmployee();
    }

    private async void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int colIndex = e.ColumnIndex;

      if (rowIndex == -1) return;
      if (colIndex == 8 || colIndex == 9) //Edit
      {
        var data = dgvEmployees.Rows[rowIndex];
        string serialCode = data.Cells[5].Value.ToString();

        if (string.IsNullOrEmpty(serialCode)) return;

        Employee employee = AppCore.Ins._employees.Where(x => x.SerialCode == serialCode).FirstOrDefault();

        if (employee != null)
        {
          if (colIndex == 8)
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.EditEmployee);
            if (rsOk)
            {
              AddEmployeeFrm addRoleUser = new AddEmployeeFrm(eTypeButton.Edit, employee);
              addRoleUser.OnSendReloadData += AddRoleUser_OnSendReloadData;
              addRoleUser.ShowDialog();
            }
            else
            {
              MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
            }
          }
          else
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.DeleteEmployee);
            if (rsOk)
            {
              var rs = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Xác nhận", MessageBoxButtons.YesNo);
              if (rs == DialogResult.Yes)
              {
                employee.IsDelete = true;
                employee.UpdatedAt = DateTime.Now;
                await AppCore.Ins.UpdateEmployee(employee);
                await AppCore.Ins.LoadData();
                UpdateUIEmployee();
              }
            }
            else
            {
              MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
            }
          }
        }
      }
    }

    private async void AddRoleUser_OnSendReloadData()
    {
      await AppCore.Ins.LoadData();
      UpdateUIEmployee();
    }

    private async void dgvTypeEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int colIndex = e.ColumnIndex;

      if (rowIndex == -1) return;
      if (colIndex == 4 || colIndex == 5) //Edit
      {
        var data = dgvTypeEmployees.Rows[rowIndex];
        string nameType = data.Cells[1].Value.ToString();

        if (string.IsNullOrEmpty(nameType)) return;

        TypeEmployee typeEmployee = AppCore.Ins._typeEmployees.Where(x => x.NameType == nameType).FirstOrDefault();

        if (typeEmployee != null)
        {
          if (colIndex == 4)
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.EditGroupTypeEmployee);
            if (rsOk)
            {
              AddTypeEmployeeFrm addRoleUser = new AddTypeEmployeeFrm(eTypeButton.Edit, typeEmployee);
              addRoleUser.OnSendReloadData += AddTypeFrm_OnSendReloadData;
              addRoleUser.ShowDialog();
            }
            else
            {
              MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
            }
          }
          else
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.DeleteGroupTypeEmployee);
            if (rsOk)
            {
              var rs = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Xác nhận", MessageBoxButtons.YesNo);
              if (rs == DialogResult.Yes)
              {
                typeEmployee.IsDelete = true;
                typeEmployee.UpdatedAt = DateTime.Now;
                await AppCore.Ins.UpdateTypeEmployee(typeEmployee);
                await AppCore.Ins.LoadData();
                UpdateUITypeEmployee();
              }
            }
            else
            {
              MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
            }
          }
        }
      }
    }

    private async void btnReloadUser_Click(object sender, EventArgs e)
    {
      await AppCore.Ins.LoadData();
      UpdateUIEmployee();
    }

    private async void btnReloadTypeEmployee_Click(object sender, EventArgs e)
    {
      await AppCore.Ins.LoadData();
      UpdateUITypeEmployee();
    }
	}
}

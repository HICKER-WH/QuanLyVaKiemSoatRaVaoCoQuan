using Project01.Controls;
using Project01.Models;
using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01.FrmChild
{
  public partial class FrmSetting : Form
  {
    public FrmSetting()
    {
      InitializeComponent();
    }


		#region Singleton parttern
		private static FrmSetting _Instance = null;
    public static FrmSetting Instance
    {
      get
      {
        if (_Instance == null)
        {
          _Instance = new FrmSetting();
        }
        return _Instance;
      }
    }

    #endregion

    private void FrmSetting_Load(object sender, EventArgs e)
    {
      UpdateUIRole();

      UpdateUIUser();

      LoadComPC();

      LoadSetting();
    }

    private void LoadSetting()
    {
      numericUpDown1.Value = Properties.Settings.Default.SencondReceidData;
      numericUpDownPort.Value = Properties.Settings.Default.Port;

      txtCheckIn.Text = Properties.Settings.Default.OutputDataStrCheckIn;
      txtCheckOut.Text = Properties.Settings.Default.OutputDataStrCheckOut;
      txtCheckNG.Text = Properties.Settings.Default.OutputDataStrCheckNG;
      cbbCOM.SelectedItem = Properties.Settings.Default.COM;
    }

    private void LoadComPC()
    {
      cbbCOM.Items.Clear();
      string[] ports = SerialPort.GetPortNames();
      foreach (string port in ports)
      {
        cbbCOM.Items.Add(port);
      }
    }

    private void btnAddRoleUser_Click(object sender, EventArgs e)
    {
      var rsOk = AppCore.Ins.CheckRole(ePermit.AddRoleUser);
      if (rsOk)
      {
        AddRoleUser addRoleUser = new AddRoleUser(eTypeButton.Add, null);
        addRoleUser.OnSendReloadData += AddRoleUser_OnSendReloadData;
        addRoleUser.ShowDialog();
      }
      else
      {
        MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
      }
    }

    private async void AddRoleUser_OnSendReloadData()
    {
      await AppCore.Ins.ReloadRoleUser();
      UpdateUIRole();
    }

    private void UpdateUIRole()
    {
      dgvRoleUser.Rows.Clear();
      if (AppCore.Ins._roleGroups.Count <= 0) return;

      int stt = 1;
      foreach (var item in AppCore.Ins._roleGroups)
      {
        int row = dgvRoleUser.Rows.Add();
        dgvRoleUser.Rows[row].Cells["Column1"].Value = stt++;
        dgvRoleUser.Rows[row].Cells["Column2"].Value = item.Name;
        dgvRoleUser.Rows[row].Cells["Column3"].Value = item.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        dgvRoleUser.Rows[row].Cells["Column6"].Value = item.UpdatedAt.ToString("HH:mm:ss dd/MM/yyyy");

        if (item.Name != "Admin")
        {
          dgvRoleUser.Rows[row].Cells["Column4"].Value = "Chỉnh sửa";
          dgvRoleUser.Rows[row].Cells["Column5"].Value = "Xóa";
        }
        else
        {
          dgvRoleUser.Rows[row].Cells["Column4"].Value = "";
          dgvRoleUser.Rows[row].Cells["Column5"].Value = "";
        }
      }

			dgvUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

    private async void dgvRoleUser_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int colIndex = e.ColumnIndex;

      if (rowIndex == -1) return;
      if (rowIndex == 0) return; //Tài khoản Admin
      if (colIndex == 4 || colIndex == 5) //Edit
      {
        var data = dgvRoleUser.Rows[rowIndex];
        string nameRole = data.Cells[1].Value.ToString();

        if (string.IsNullOrEmpty(nameRole)) return;

        RoleGroup roleGroup = AppCore.Ins._roleGroups.Where(x => x.Name == nameRole).FirstOrDefault();

        if (roleGroup != null)
        {
          if (colIndex == 4)
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.EditRoleUser);
            if (rsOk)
            {
              AddRoleUser addRoleUser = new AddRoleUser(eTypeButton.Edit, roleGroup);
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
            var rsOk = AppCore.Ins.CheckRole(ePermit.DeleteRoleUser);
            if (rsOk)
            {
              var rs = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Xác nhận", MessageBoxButtons.YesNo);
              if (rs == DialogResult.Yes)
              {
                roleGroup.IsDelete = true;
                roleGroup.UpdatedAt = DateTime.Now;
                await AppCore.Ins.UpdateRoleUsers(roleGroup);
                await AppCore.Ins.ReloadRoleUser();
                UpdateUIRole();
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

    private void UpdateUIUser()
    {
      dgvUser.Rows.Clear();
      if (AppCore.Ins._users.Count <= 0) return;

      int stt = 1;
      foreach (var item in AppCore.Ins._users)
      {
        int row = dgvUser.Rows.Add();
        dgvUser.Rows[row].Cells["Column11"].Value = stt++;
        dgvUser.Rows[row].Cells["Column12"].Value = item.Name;
        dgvUser.Rows[row].Cells["Column17"].Value = item.RoleGroup.Name;
        dgvUser.Rows[row].Cells["Column13"].Value = item.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        dgvUser.Rows[row].Cells["Column16"].Value = item.UpdatedAt.ToString("HH:mm:ss dd/MM/yyyy");
        

        if (item.Name!= "admin")
        {
          dgvUser.Rows[row].Cells["Column14"].Value = "Chỉnh sửa";
          dgvUser.Rows[row].Cells["Column15"].Value = "Xóa";
        }  
        else
        {
          dgvUser.Rows[row].Cells["Column14"].Value = "";
          dgvUser.Rows[row].Cells["Column15"].Value = "";
        }  

      }
			dgvRoleUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

    private void btnAddUser_Click(object sender, EventArgs e)
    {
      var rsOk = AppCore.Ins.CheckRole(ePermit.AddUser);
      if (rsOk)
      {
        AddUser addUser = new AddUser(eTypeButton.Add, null);
        addUser.OnSendReloadData += AddUser_OnSendReloadData;
        addUser.ShowDialog();
      }
      else
      {
        MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
      }
    }

    private async void AddUser_OnSendReloadData()
    {
      await AppCore.Ins.ReloadRoleUser();
      UpdateUIUser();
    }

    private async void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int colIndex = e.ColumnIndex;

      if (rowIndex == -1) return;
      if (rowIndex == 0) return; //Tài khoản Admin
      if (colIndex == 6 || colIndex == 5)
      {
        var data = dgvUser.Rows[rowIndex];
        string nameUser = data.Cells[1].Value.ToString();

        if (string.IsNullOrEmpty(nameUser)) return;

        User user = AppCore.Ins._users.Where(x => x.Name == nameUser).FirstOrDefault();

        if (user != null)
        {
          if (colIndex == 5)
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.EditUser);
            if (rsOk)
            {
              AddUser addUser = new AddUser(eTypeButton.Edit, user);
              addUser.OnSendReloadData += AddUser_OnSendReloadData;
              addUser.ShowDialog();
            }
            else
            {
              MessageBox.Show("Bạn không có phân quyền thực hiện hành động này !");
            }
          }
          else
          {
            var rsOk = AppCore.Ins.CheckRole(ePermit.DeleteUser);
            if (rsOk)
            {
              var rs = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu ?", "Xác nhận", MessageBoxButtons.YesNo);
              if (rs == DialogResult.Yes)
              {
                user.IsDelete = true;
                user.UpdatedAt = DateTime.Now;
                await AppCore.Ins.UpdateUser(user);
                await AppCore.Ins.ReloadRoleUser();
                UpdateUIUser();
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

    private void btnReloadUser_Click(object sender, EventArgs e)
    {
      UpdateUIUser();
    }

    private void btnReloadRoleUser_Click(object sender, EventArgs e)
    {
      UpdateUIRole();
    }

    private void btnSaveSettingSecond_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.SencondReceidData = (int)numericUpDown1.Value;
      Properties.Settings.Default.Save();

      FrmHome.Instance.scanCooldown = TimeSpan.FromSeconds((int)numericUpDown1.Value);
    }


    private void btnSaveSettingOutput_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.OutputDataStrCheckIn = txtCheckIn.Text;
      Properties.Settings.Default.OutputDataStrCheckOut = txtCheckOut.Text;
      Properties.Settings.Default.OutputDataStrCheckNG =txtCheckNG.Text;
      Properties.Settings.Default.COM = cbbCOM.SelectedIndex != -1 ? cbbCOM.SelectedItem.ToString() : "";
      Properties.Settings.Default.Port = (int) numericUpDownPort.Value;
      Properties.Settings.Default.Save();

    }

    private void btnReloadCom_Click(object sender, EventArgs e)
    {
      LoadComPC();
    }

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}
	}
}

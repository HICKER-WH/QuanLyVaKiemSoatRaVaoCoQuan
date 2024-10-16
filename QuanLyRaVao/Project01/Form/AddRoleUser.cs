using Project01.Controls;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01.FrmChild
{
  public partial class AddRoleUser : Form
  {
    public delegate void SendReloadData();
    public event SendReloadData OnSendReloadData;

    private RoleGroup _roleGroup { get; set; }
    private eTypeButton _eTypeButton { get; set; }
    public AddRoleUser(eTypeButton eTypeButton, RoleGroup roleGroup)
    {
      InitializeComponent();

      btnAdd.Visible = (eTypeButton == eTypeButton.Add);
      btnUpdate.Visible = (eTypeButton == eTypeButton.Edit);

      _roleGroup = roleGroup;
      _eTypeButton = eTypeButton;
    }

    private void AddRoleUser_Load(object sender, EventArgs e)
    {
      if (_eTypeButton==eTypeButton.Edit)
      {
        List<ePermit> ePermits = new List<ePermit>();
        ePermits.Add(ePermit.AddEmployee);
        ePermits.Add(ePermit.EditEmployee);
        ePermits.Add(ePermit.DeleteEmployee);

        ePermits.Add(ePermit.AddGroupTypeEmployee);
        ePermits.Add(ePermit.EditGroupTypeEmployee);
        ePermits.Add(ePermit.DeleteGroupTypeEmployee);

        ePermits.Add(ePermit.SeeReport);

        ePermits.Add(ePermit.AddUser);
        ePermits.Add(ePermit.EditUser);
        ePermits.Add(ePermit.DeleteUser);

        ePermits.Add(ePermit.AddRoleUser);
        ePermits.Add(ePermit.EditRoleUser);
        ePermits.Add(ePermit.DeleteRoleUser);

        ucCheckBoxs1.SetRoleUser(_roleGroup.Role, ePermits);
        txtNameRole.Text = _roleGroup.Name;
      }  
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      string roleStr = ucCheckBoxs1.GetRoleUser();

      _roleGroup.Role  = roleStr;
      _roleGroup.Name = txtNameRole.Text;
      _roleGroup.UpdatedAt = DateTime.Now;

      await AppCore.Ins.UpdateRoleUsers(_roleGroup);
      OnSendReloadData?.Invoke();
      this.Close();
    }

    private async void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtNameRole.Text))
      {
        MessageBox.Show("Không được để trống tên !");
        return;
      }

      var exits = AppCore.Ins._roleGroups.Any(x => x.Name == txtNameRole.Text);
      if (exits)
      {
        MessageBox.Show("Tên nhóm phân quyền đã tồn tại. Vui lòng đặt tên khác !");
        return;
      }

      string roleStr = ucCheckBoxs1.GetRoleUser();
      RoleGroup roleGroup = new RoleGroup()
      {
        Name = txtNameRole.Text,
        Role = roleStr,
      };
      await AppCore.Ins.AddRoleUser(roleGroup);
      OnSendReloadData?.Invoke();
      this.Close();
    }

		private void label12_Click(object sender, EventArgs e)
		{

		}
	}
}

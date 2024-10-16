using Project01.Controls;
using Project01.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Project01.eNum.enumSW;

namespace Project01.FrmChild
{
  public partial class AddUser : Form
  {
    public delegate void SendReloadData();
    public event SendReloadData OnSendReloadData;

    private eTypeButton _eTypeButton;
    private User _user;
    public AddUser(eTypeButton eTypeButton, User user)
    {
      InitializeComponent();

      btnAdd.Visible = eTypeButton == eTypeButton.Add;
      btnUpdate.Visible = eTypeButton == eTypeButton.Edit;

      _eTypeButton = eTypeButton;
      _user = user;
    }

    private void AddUser_Load(object sender, EventArgs e)
    {
      cbbTypeRole.DataSource = AppCore.Ins._roleGroups.Select(r => r.Name).ToList();

      if (_eTypeButton == eTypeButton.Edit)
      {
        txtName.Text = _user.Name;
        txtPass.Text = _user.Password;
        txtRepass.Text = _user.Password;
        cbbTypeRole.SelectedItem = _user.RoleGroup.Name;
      }
    }

    private async void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtName.Text))
      {
        MessageBox.Show("Không được để trống tên !");
        return;
      }

      var exits = AppCore.Ins._users.Any(x => x.Name == txtName.Text);
      if (exits)
      {
        MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng đặt tên khác !");
        return;
      }

      if (string.IsNullOrEmpty(txtPass.Text))
      {
        MessageBox.Show("Không được để trống mật khẩu !");
        return;
      }

      if (txtPass.Text != txtRepass.Text)
      {
        MessageBox.Show("Mật khẩu nhập lại không khớp !");
        return;
      }

      RoleGroup roleGroup = AppCore.Ins._roleGroups.Where(r => r.Name == cbbTypeRole.SelectedItem.ToString()).FirstOrDefault();
      User user = new User()
      {
        Name = txtName.Text,
        Password = txtPass.Text,
        RoleGroupId = roleGroup.Id,
      };

      await AppCore.Ins.AddUser(user);
      OnSendReloadData?.Invoke();
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtName.Text))
      {
        MessageBox.Show("Không được để trống tên !");
        return;
      }
      if (string.IsNullOrEmpty(txtPass.Text))
      {
        MessageBox.Show("Không được để trống mật khẩu !");
        return;
      }

      if (txtPass.Text != txtRepass.Text)
      {
        MessageBox.Show("Mật khẩu nhập lại không khớp !");
        return;
      }

      _user.Name = txtName.Text;
      _user.Password = txtPass.Text;
      _user.UpdatedAt = DateTime.Now;

      var role = AppCore.Ins._roleGroups.Where(x => x.Name == cbbTypeRole.SelectedItem.ToString()).FirstOrDefault();
      if (role!=null)
      {
        //_user.RoleGroupId = role.Id;
        _user.RoleGroup = role;
      }  

      await AppCore.Ins.UpdateUser(_user);
      OnSendReloadData?.Invoke();
      this.Close();
    }
  }
}

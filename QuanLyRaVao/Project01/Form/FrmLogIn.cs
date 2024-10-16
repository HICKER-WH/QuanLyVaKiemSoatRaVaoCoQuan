using Project01.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project01.FrmChild
{
  public partial class FrmLogIn : Form
  {
    public delegate void SendLogInOK(User user);
    public event SendLogInOK OnSendLogInOK;

    private List<User> _users;
    public FrmLogIn(List<User> users)
    {
      InitializeComponent();
      _users = users;
    }

    private void FrmLogIn_Load(object sender, EventArgs e)
    {
      this.txtAccount.Focus();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var rs = _users.Where(x => x.Name == this.txtAccount.Text).FirstOrDefault();
      if (rs != null)
      {
        if (rs.Password == txtPassword.Text)
        {			
					OnSendLogInOK?.Invoke(rs);
          this.Close();
        }
        else
        {
					MessageBox.Show("Mật khẩu không chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtPassword.Clear();
					txtPassword.Focus();
				}
      }
      else
      {
				MessageBox.Show("Không tìm thấy tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtAccount.Clear();
				txtPassword.Clear();
				txtAccount.Focus();
			}
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}

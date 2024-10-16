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

namespace Project01.UC
{
  public partial class UcCheckBoxs : UserControl
  {
    public UcCheckBoxs()
    {
      InitializeComponent();
    }

    public string GetRoleUser()
    {
      string role = "";
      role += (ucCheckbox1.IsCheck()) ? $"{ePermit.AddEmployee}" : "";
      role += (ucCheckbox2.IsCheck()) ? $"_{ePermit.EditEmployee}" : "";
      role += (ucCheckbox3.IsCheck()) ? $"_{ePermit.DeleteEmployee}" : "";

      role += (ucCheckbox4.IsCheck()) ? $"_{ePermit.AddGroupTypeEmployee}" : "";
      role += (ucCheckbox5.IsCheck()) ? $"_{ePermit.EditGroupTypeEmployee}" : "";
      role += (ucCheckbox6.IsCheck()) ? $"_{ePermit.DeleteGroupTypeEmployee}" : "";

      role += (ucCheckbox7.IsCheck()) ? $"_{ePermit.SeeReport}" : "";

      role += (ucCheckbox8.IsCheck()) ? $"_{ePermit.AddUser}" : "";
      role += (ucCheckbox9.IsCheck()) ? $"_{ePermit.EditUser}" : "";
      role += (ucCheckbox10.IsCheck()) ? $"_{ePermit.DeleteUser}" : "";

      role += (ucCheckbox11.IsCheck()) ? $"_{ePermit.AddRoleUser}" : "";
      role += (ucCheckbox12.IsCheck()) ? $"_{ePermit.EditRoleUser}" : "";
      role += (ucCheckbox13.IsCheck()) ? $"_{ePermit.DeleteRoleUser}" : "";
      return role;
    }

    public void SetRoleUser(string role, List<ePermit> permits)
    {
      ucCheckbox1.SetCheck = SetRoleRole(role, permits[0]);
      ucCheckbox2.SetCheck = SetRoleRole(role, permits[1]);
      ucCheckbox3.SetCheck = SetRoleRole(role, permits[2]);
      ucCheckbox4.SetCheck = SetRoleRole(role, permits[3]);
      ucCheckbox5.SetCheck = SetRoleRole(role, permits[4]);
      ucCheckbox6.SetCheck = SetRoleRole(role, permits[5]);
      ucCheckbox7.SetCheck = SetRoleRole(role, permits[6]);
      ucCheckbox8.SetCheck = SetRoleRole(role, permits[7]);
      ucCheckbox9.SetCheck = SetRoleRole(role, permits[8]);
      ucCheckbox10.SetCheck = SetRoleRole(role, permits[9]);
      ucCheckbox11.SetCheck = SetRoleRole(role, permits[10]);
      ucCheckbox12.SetCheck = SetRoleRole(role, permits[11]);
      ucCheckbox13.SetCheck = SetRoleRole(role, permits[12]);
    }

    public bool SetRoleRole(string role, ePermit permit)
    {
      return role.Contains(permit.ToString());
    }

  }
}

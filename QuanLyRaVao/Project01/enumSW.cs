using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.eNum
{
  public class enumSW
  {
    public enum AppModulSupport
    {
      DashBoard,
      MasterData,
      Report,
      Setting,
      Synchronized,
    }

    public enum eStatus
    {
      All,
      CheckIn,
      CheckOut,
      None,
    }

    public enum ePermit
    {
      None,

      AddEmployee,
      EditEmployee,
      DeleteEmployee,

      AddGroupTypeEmployee,
      EditGroupTypeEmployee,
      DeleteGroupTypeEmployee,

      SeeReport,

      AddUser,
      EditUser,
      DeleteUser,

      AddRoleUser,
      EditRoleUser,
      DeleteRoleUser,
    }

    public enum eTypeButton
    {
      None,
      Add,
      Edit,
    }





  }
}

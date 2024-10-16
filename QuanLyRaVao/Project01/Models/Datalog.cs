using System.ComponentModel;
using static Project01.eNum.enumSW;

namespace Project01.Models
{
  public class Datalog : BaseModel
  {
    [DisplayName("Trạng thái")]
    public eStatus eStatus { get; set; }

    [Browsable(false)]
    public int? EmployeeId { get; set; }
  }
}

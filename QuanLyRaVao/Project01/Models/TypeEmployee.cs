using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.Models
{
  public class TypeEmployee:BaseModel
  {
    [DisplayName("Tên nhóm")]
    public string NameType { get; set; }
    [Browsable(false)]
    public ICollection<Employee> Employees { get; set; }

  }
}

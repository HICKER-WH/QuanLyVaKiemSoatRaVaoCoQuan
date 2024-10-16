using Project01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.Models
{
  public class User:BaseModel
  {
    public string Name { get; set; }
    public string Password { get; set; }
    [Browsable(false)]
    public int? RoleGroupId { get; set; }

    [Browsable(false)]
    public RoleGroup RoleGroup { get; set; }
  }
}

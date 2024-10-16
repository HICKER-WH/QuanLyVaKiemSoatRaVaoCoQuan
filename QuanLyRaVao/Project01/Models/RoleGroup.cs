using System.Collections.Generic;
using System.ComponentModel;

namespace Project01.Models
{
  public class RoleGroup : BaseModel
  {
    [DisplayName("Tên nhóm phân quyền")]
    public string Name { get; set; }
    [Browsable(false)]
    public string Role { get; set; }
    [Browsable(false)]
    public ICollection<User> Users { get; set; }
  }
}

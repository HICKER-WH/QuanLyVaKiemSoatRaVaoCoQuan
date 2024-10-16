using Project01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project01.eNum.enumSW;

namespace Project01.Models
{
  public class Employee : BaseModel
  {
    [DisplayName("Họ và tên")]
    public string FullName { get; set; }
    [DisplayName("Số CCCD")]
    public string CCCD { get; set; }
    [DisplayName("Số điện thoại")]
    public string Phone { get; set; }
    [DisplayName("Mã chấm công")]
    public string SerialCode { get; set; }
    [DisplayName("Đường dẫn hình ảnh")]
    [Browsable(false)]
    public string PathImage { get; set; }

    [Browsable(false)]
    public int? TypeEmployeeId { get; set; }

    [Browsable(false)]
    public TypeEmployee TypeEmployee { get; set; }
  }
}

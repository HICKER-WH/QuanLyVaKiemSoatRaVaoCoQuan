using System;
using System.ComponentModel;
using static Project01.eNum.enumSW;

namespace Project01.Models
{
  public class DatalogsDTO
  {
    public int STT { get; set; }
    [DisplayName("Họ và tên")]
    public string FullName { get; set; }
    [DisplayName("Số CCCD")]
    public string CCCD { get; set; }
    [DisplayName("Số điện thoại")]
    public string Phone { get; set; }
    [DisplayName("Tên nhóm")]
    public string NameType { get; set; }
    [DisplayName("Trạng thái")]
    public eStatus eStatus { get; set; }

    [DisplayName("Ngày tạo")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
  }
}

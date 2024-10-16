using DocumentFormat.OpenXml.Office.Word;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using static Project01.eNum.enumSW;
using static Project01.Models.DbStore;
using Application = System.Windows.Forms.Application;
using DateTime = System.DateTime;
using File = System.IO.File;

namespace Project01.Controls
{
  public partial class AppCore
  {
    private static AppCore _ins = new AppCore();
    public static AppCore Ins
    {
      get
      {
        return _ins == null ? _ins = new AppCore() : _ins;
      }
    }

    public void Init()
    {
      LoadConfigsDB();

      LoadData().Wait();

      InitBaseSoftware();

      InitDevice();

      StartShowUI();
    }

    public string pathFolderImage = Application.StartupPath + $"\\CSDL_Image";
    private void InitBaseSoftware()
    {
      if (!Directory.Exists($"{pathFolderImage}"))
      {
        Directory.CreateDirectory($"{pathFolderImage}");
      }
    }

    public List<Employee> _employees = new List<Employee>();
    public List<TypeEmployee> _typeEmployees = new List<TypeEmployee>();
    public List<RoleGroup> _roleGroups = new List<RoleGroup>();
    public List<User> _users = new List<User>();
    public User _userCurrent = null;
    public List<Datalog> _listDataOld = new List<Datalog>();
    public int _secondReceidData = 5;
    public string _com = "";
    public int _baud = 9600;
    public async Task LoadData()
    {
      _employees = await LoadEmployees();
      _typeEmployees = await LoadTypeEmployees();
      _roleGroups = await LoadRoleUsers();
      _users = await LoadUsers();
      _listDataOld = await ResearchDatalogs(DateTime.Now);
      _secondReceidData = Properties.Settings.Default.SencondReceidData;

      _com = Properties.Settings.Default.COM;
      _baud = Properties.Settings.Default.Port;
    }

    public void LoadConfigsDB()
    {
      try
      {
        DataBase.Init().Wait();
      }
      catch (Exception ex)
      {
        LogErrorToFileLog("Lỗi khi khởi tạo chương trình, vui lòng khởi động lại!" + ex.ToString());
        System.Windows.Forms.MessageBox.Show($"Lỗi khi khởi tạo chương trình, vui lòng khởi động lại!", "Lỗi");
        Environment.Exit(2);
      }
    }

    public bool CheckRole(string role, ePermit permit)
    {
      role = (role == null) ? "" : role;
      return role.Contains(permit.ToString());
    }

    public bool CheckRole(ePermit permit)
    {
      string roleStr = _userCurrent != null ? _userCurrent.RoleGroup.Role : "";
      return roleStr.Contains(permit.ToString());
    }


    public async Task ReloadRoleUser()
    {
      _users = await LoadUsers();
      _roleGroups = await LoadRoleUsers();
      if (_userCurrent != null)
      {
        _userCurrent = _users.Where(x => x.Id == _userCurrent.Id && x.IsDelete == false).FirstOrDefault();
      }
    }

    public async Task ReloadEmployee()
    {
      _employees = await LoadEmployees();
      _typeEmployees = await LoadTypeEmployees();
    }


    private async Task<List<Datalog>> ResearchDatalogs(DateTime fileDb)
    {
      var rs = await AppCore.Ins.LoadDatalogs(fileDb);
      if (rs != null)
      {
        return rs.OrderByDescending(x => x.Id).Take(50).ToList();
      }
      else
      {
        return null;
      }
    }



    public void LogErrorToFileLog(string content)
    {
      string NameFileLog = Application.StartupPath + $"\\logError.txt";
      if (!File.Exists(NameFileLog))
      {
        File.Create(NameFileLog);
      }
      string contentLog = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + $": Content: {content} \r\n";
      File.AppendAllText(NameFileLog, contentLog);
    }



    public SerialPort serialPort;
    public void InitDevice()
    {
      try
      {
        serialPort = new SerialPort(_com, _baud);
        serialPort.Open();
      }
      catch (Exception)
      {
      }
    }

    public void SendSerrial(string data)
    {
      try
      {
        if (serialPort!=null)
        {
          if (serialPort.IsOpen)
          {
            serialPort.Write($"{data}\r\n");
          }  
        }  
      }
      catch (Exception)
      {

      }
    }


    public void CloseSerialDevice()
    {
      try
      {
        if (serialPort != null)
        {
          if (serialPort.IsOpen)
          {
            serialPort.Close();
            serialPort.Dispose();
          }
        }
      }
      catch (Exception)
      {

      }
    }



  }
}

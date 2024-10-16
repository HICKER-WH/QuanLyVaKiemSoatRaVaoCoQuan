using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project01.Models.DbStore;

namespace Project01.Controls
{
  public class DataBase
  {
    private static DataBase _ins;

    public static DataBase Ins
    {
      get { return _ins == null ? _ins = new DataBase() : _ins; }
    }
    public static string DailyDbPath { get; set; }
    public static string ConfigDbPath { get; set; } = $"./configDb.sqlite";

    //public static 
    public static async Task<int> Init()
    {
      var folder = Application.StartupPath + $"\\DataBase";
      if (!Directory.Exists($"{folder}"))
      {
        Directory.CreateDirectory($"{folder}");
      }

      using (var db = new ConfigDBContext())
      {
        try
        {
          await db.Database.EnsureCreatedAsync();
          await db.Database.BeginTransactionAsync();

          //Roles
          if (db.RoleGroups.Count() <= 0)
          {
            await db.RoleGroups.AddRangeAsync(new RoleGroup[]
            {
              new RoleGroup(){ Name="Admin", Role="AddEmployee_EditEmployee_DeleteEmployee_AddGroupTypeEmployee_EditGroupTypeEmployee_DeleteGroupTypeEmployee_SeeReport_AddUser_EditUser_DeleteUser_AddRoleUser_EditRoleUser_DeleteRoleUser",  CreatedAt=DateTime.Now, UpdatedAt=DateTime.Now, IsDelete=false},
            });
          }
          await db.SaveChangesAsync();

          //Roles
          if (db.Users.Count() <= 0)
          {
            await db.Users.AddRangeAsync(new User[]
            {
              new User(){ Name="admin", Password="admin",RoleGroupId=1,  CreatedAt=DateTime.Now, UpdatedAt=DateTime.Now, IsDelete=false},
            });
          }
          await db.SaveChangesAsync();
          db.Database.CommitTransaction();
        }
        catch (Exception ex)
        {
          db.Database.RollbackTransaction();
          AppCore.Ins.LogErrorToFileLog(ex.ToString());
        }

        DateTime dt = DateTime.Now;
        using (var daily = new DailyDBContext(dt.AddDays(-1).ToString("yyMMdd")))
        {
          await daily.Database.EnsureCreatedAsync();
        }
        using (var daily = new DailyDBContext(dt.ToString("yyMMdd")))
        {
          await daily.Database.EnsureCreatedAsync();
        }
        using (var daily = new DailyDBContext(dt.AddDays(1).ToString("yyMMdd")))
        {
          await daily.Database.EnsureCreatedAsync();
        }
      }
      return 1;
    }



  }
}

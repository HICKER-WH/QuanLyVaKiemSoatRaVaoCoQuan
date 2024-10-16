using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01.Models
{
  public class DbStore
  {
    public class DailyDBContext : DbContext
    {
      public string DailyDbPath = Application.StartupPath;
      public DbSet<Datalog> Datalogs { get; set; }
      public DailyDBContext(string fileName)
      {
        DailyDbPath = Application.StartupPath + $"\\DataBase\\{fileName}.sqlite";
      }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        if (!optionsBuilder.IsConfigured)
        {
          optionsBuilder.UseSqlite($"Data Source={DailyDbPath}");
        }
      }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {

      }

    }



    public class ConfigDBContext : DbContext
    {
      public DbSet<Employee> Employees { get; set; }
      public DbSet<TypeEmployee> TypeEmployees { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<RoleGroup> RoleGroups { get; set; }

      public string DebugPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
      public ConfigDBContext()
      {
        DebugPath += $"\\ConfigDB.sqlite";
      }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        if (!optionsBuilder.IsConfigured)
        {
          optionsBuilder.UseSqlite($"Data Source={DebugPath}");
        }
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
       
      }
    }
  }
}

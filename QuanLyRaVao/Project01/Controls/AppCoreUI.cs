using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project01.eNum.enumSW;
using static Project01.Models.DbStore;

namespace Project01.Controls
{
  public partial class AppCore
  {
    private void StartShowUI()
    {
      Application.Run(FrmMain.Instance);
    }

    public async Task AddTypeEmployee(TypeEmployee typeEmployee)
    {
      using (var context = new ConfigDBContext())
      {
        var repo = new GenericRepository<TypeEmployee, ConfigDBContext>(context);
        await repo.Add(typeEmployee);
      }
    }
    public async Task AddEmployee(Employee employee)
    {
      using (var context = new ConfigDBContext())
      {
        var repo = new GenericRepository<Employee, ConfigDBContext>(context);
        await repo.Add(employee);
      }
    }

    public async Task<bool> AddDatalog(Datalog datalog)
    {
      using (var context = new DailyDBContext(DateTime.Now.ToString("yyMMdd")))
      {
        var repo = new GenericRepository<Datalog, DailyDBContext>(context);
        return await repo.Add(datalog);
      }
    }

    public async Task<eStatus> CheckStatus(int employeeId)
    {
      using (var context = new DailyDBContext(DateTime.Now.ToString("yyMMdd")))
      {
        var repo = new GenericRepository<Datalog, DailyDBContext>(context);
        var data = await repo.GetAllAsync();
        if (data!= null)
        {
          var rs = data.Where(x=>x.EmployeeId== employeeId).OrderByDescending(x=>x.Id).FirstOrDefault();
          if (rs != null)
          {
            return rs.eStatus == eStatus.CheckIn ? eStatus.CheckOut : eStatus.CheckIn;
          }
          else
          {
            return eStatus.CheckIn;
          }

        }  
        else
        {
          return eStatus.CheckIn;
        }  
      }
    }


    public async Task AddRoleUser(RoleGroup role)
    {
      using (var context = new ConfigDBContext())
      {
        var repo = new GenericRepository<RoleGroup, ConfigDBContext>(context);
        await repo.Add(role);
      }
    }

    public async Task<List<TypeEmployee>> LoadTypeEmployees()
    {
      using (var context = new ConfigDBContext())
      {
        var repo = new GenericRepository<TypeEmployee, ConfigDBContext>(context);
        var data = await repo.GetAllAsync();
        return data.Where(x => x.IsDelete == false).OrderBy(x => x.Id).ToList();
      }
    }


    public async Task<List<Employee>> LoadEmployees()
    {
      using (var context = new ConfigDBContext())
      {
        return await context.Employees.Include(x => x.TypeEmployee).Where(x => x.IsDelete == false).ToListAsync();
      }
    }

    public async Task<List<Datalog>> LoadDatalogs(DateTime dateTime)
    {
      try
      {
        using (var context = new DailyDBContext(dateTime.ToString("yyMMdd")))
        {
          return await context.Datalogs.Where(x => x.IsDelete == false).ToListAsync();
        }
      }
      catch (Exception)
      {
        return null;
      }
      
    }


    public async Task<List<RoleGroup>> LoadRoleUsers()
    {
      using (var context = new ConfigDBContext())
      {
        var repo = new GenericRepository<RoleGroup, ConfigDBContext>(context);
        var data = await repo.GetAllAsync();
        return data.Where(x => x.IsDelete == false).OrderBy(x => x.Id).ToList();
      }
    }

    public async Task UpdateRoleUsers(RoleGroup roleGroup)
    {
      using (var context = new ConfigDBContext())
      {
        context.Database.BeginTransaction();
        try
        {
          context.Set<RoleGroup>().Update(roleGroup);
          await context.SaveChangesAsync();
          context.Database.CommitTransaction();
        }
        catch (Exception)
        {
          context.Database.RollbackTransaction();
        }
      }
    }

    public async Task UpdateUser(User user)
    {
      using (var context = new ConfigDBContext())
      {
        context.Database.BeginTransaction();
        try
        {
          context.Set<User>().Update(user);
          await context.SaveChangesAsync();
          context.Database.CommitTransaction();
        }
        catch (Exception)
        {
          context.Database.RollbackTransaction();
        }
      }
    }

    public async Task UpdateEmployee(Employee employee)
    {
      using (var context = new ConfigDBContext())
      {
        context.Database.BeginTransaction();
        try
        {
          context.Set<Employee>().Update(employee);
          await context.SaveChangesAsync();
          context.Database.CommitTransaction();
        }
        catch (Exception)
        {
          context.Database.RollbackTransaction();
        }
      }
    }

    public async Task UpdateTypeEmployee(TypeEmployee typeEmployee)
    {
      using (var context = new ConfigDBContext())
      {
        context.Database.BeginTransaction();
        try
        {
          context.Set<TypeEmployee>().Update(typeEmployee);
          await context.SaveChangesAsync();
          context.Database.CommitTransaction();
        }
        catch (Exception)
        {
          context.Database.RollbackTransaction();
        }
      }
    }

    public async Task<List<User>> LoadUsers()
    {
      using (var context = new ConfigDBContext())
      {
        return await context.Users.Include(x => x.RoleGroup).Where(x => x.IsDelete == false).ToListAsync();
      }
    }

    public async Task AddUser(User data)
    {
      using (var context = new ConfigDBContext())
      {
        var repo = new GenericRepository<User, ConfigDBContext>(context);
        await repo.Add(data);
      }
    }





  }
}

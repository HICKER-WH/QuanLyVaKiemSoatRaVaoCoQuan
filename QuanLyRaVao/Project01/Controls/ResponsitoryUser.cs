using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Project01.Models.DbStore;

namespace Project01.Controls
{
  public class ResponsitoryUser : GenericRepository<User, ConfigDBContext>
  {
    public ResponsitoryUser() : base()
    {

    }
    public ResponsitoryUser(DbContext context) : base(context)
    {

    }

    public override async Task<bool> CheckExitUser(string user)
    {
      bool isExit = false;
      Context.Database.BeginTransaction();
      try
      {
        var existed = await this.Context.Set<User>().Where(s => s.Name == user).ToListAsync();
        if (existed != null && existed.Count > 0) isExit = true;
      }
      catch (Exception)
      {
      }
      return isExit;
    }

   





  }
}

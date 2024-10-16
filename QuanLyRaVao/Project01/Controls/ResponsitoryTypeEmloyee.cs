using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Threading.Tasks;
using static Project01.Models.DbStore;

namespace Project01.Controls
{
  public class ResponsitoryTypeEmloyee : GenericRepository<TypeEmployee, ConfigDBContext>
  {
    public ResponsitoryTypeEmloyee() : base()
    {

    }
    public ResponsitoryTypeEmloyee(DbContext context) : base(context)
    {

    }

    public override async Task<bool> UpdateInfoLine(TypeEmployee line)
    {
      Context.Database.BeginTransaction();
      try
      {
        this.Context.Set<TypeEmployee>().Update(line);
        await this.Context.SaveChangesAsync();
        Context.Database.CommitTransaction();
      }
      catch (Exception)
      {
        Context.Database.RollbackTransaction();
      }
      return true;
    }




  }


}

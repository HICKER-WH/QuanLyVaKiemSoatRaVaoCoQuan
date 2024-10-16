using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Project01.Models.DbStore;

namespace Project01.Controls
{
  public class ResponsitoryDatalog : GenericRepository<Employee, DailyDBContext>
  {
    public ResponsitoryDatalog(DbContext context) : base(context)
    {

    }
  }
}

using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project01.Controls
{
  public class GenericRepository<TEntity, TContext> where TEntity : class where TContext : DbContext
  {
    public DbContext Context { get; set; }
    public GenericRepository(DbContext context)
    {
      this.Context = context;
    }

    public GenericRepository()
    {

    }

    public async Task<List<TEntity>> GetAllAsync()
    {
      return await this.Context.Set<TEntity>().ToListAsync();
    }


    public async Task<bool> Add(TEntity datas)
    {
      try
      {
        await Context.Database.BeginTransactionAsync();
        await Context.Database.EnsureCreatedAsync();
        await Context.Set<TEntity>().AddAsync(datas);
        await Context.SaveChangesAsync();
        Context.Database.CommitTransaction();
        return true;
      }
      catch (Exception)
      {
        Context.Database.RollbackTransaction();
        return false;
      }
    }

    public async Task Delete(TEntity datas)
    {
      try
      {
        await Context.Database.BeginTransactionAsync();
        var dbset = Context.Set<TEntity>();
        dbset.Remove(datas);
        await Context.SaveChangesAsync();
        Context.Database.CommitTransaction();
      }
      catch (Exception)
      {
        Context.Database.RollbackTransaction();
      }
    }


    public async Task AddRange(List<TEntity> datas)
    {
      try
      {
        await Context.Database.EnsureCreatedAsync();
        await Context.Database.BeginTransactionAsync();
        await Context.Set<TEntity>().AddRangeAsync(datas);
        await Context.SaveChangesAsync();
        Context.Database.CommitTransaction();
      }
      catch (Exception)
      {
        Context.Database.RollbackTransaction();
      }

    }


    public virtual Task<bool> UpdateRange(TEntity entity)
    {
      throw new NotImplementedException();
    }

    public virtual Task<bool> UpdateActiveProduct(string FGs)
    {
      throw new NotImplementedException();
    }
    public virtual Task<bool> UpdateClearActiveProduct()
    {
      throw new NotImplementedException();
    }

    public virtual Task<bool> UpdateRangeMasterDataOld()
    {
      throw new NotImplementedException();
    }

    public virtual Task<bool> ClearActiveProductCurrent()
    {
      throw new NotImplementedException();
    }
    public virtual Task<bool> ActiveProductCurrent(string FGs)
    {
      throw new NotImplementedException();
    }




    public virtual Task<bool> CheckExitUser(string user)
    {
      throw new NotImplementedException();
    }

    public virtual Task ClearActiveUser(string role)
    {
      throw new NotImplementedException();
    }


    public virtual Task ActiveUser(string user, string role)
    {
      throw new NotImplementedException();
    }

    public virtual Task<bool> UpdateInfoLine(TypeEmployee line)
    {
      throw new NotImplementedException();
    }


  }
}

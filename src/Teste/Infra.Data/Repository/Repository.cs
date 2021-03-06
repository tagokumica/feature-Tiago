using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.Interface.Repository;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected TesteContext testeContext;
        protected DbSet<TEntity> DbSet;

        public Repository(TesteContext context)
        {
            testeContext = context;
            DbSet = testeContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList();
        }

        public void Dispose()
        {
            testeContext.Dispose();
            GC.SuppressFinalize(this);
        }



        public int SaveChanges()
        {
            return testeContext.SaveChanges();
        }



        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }


        public TEntity Update(TEntity obj)
        {
            var entry = testeContext.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }


        public TEntity FindbyId(Guid id)
        {
            return DbSet.Find(id);
        }

        public TEntity Insert(TEntity obj)
        {
            return DbSet.Add(obj).Entity;
        }
    }
}
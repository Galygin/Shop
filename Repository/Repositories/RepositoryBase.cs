using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Context;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase  //class
    {
        protected ProductContext _db;
        private readonly IDbSet<T> _dbSet;

        protected RepositoryBase(ProductContext context)
        {
            _db = context;
            _dbSet = _db.Set<T>();
        }

        public virtual void Add(T m)
        {
            _dbSet.Add(m);
        }

        public virtual void Delete(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));

        }

        public virtual void Edit(T m)
        {
        }

        public virtual T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<T> Entities()
        {
            return _dbSet;
        }

        public virtual void Save()
        {
            _db.SaveChanges();
        }
    }
}

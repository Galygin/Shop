using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Context;


namespace Repository.Repository
{
    public class SQLAccountRepository : IRepository<Account>
    {
        private ProductContext db;

        public SQLAccountRepository()
        {
            this.db = new ProductContext();
        }

        public IEnumerable<Account> GetList()
        {
            return db.Accounts;
        }

        public Account Get(int id)
        {
            return db.Accounts.Find(id);
        }

        public void Create(Account ac)
        {
            db.Accounts.Add(ac);
        }

        public void Update(Account ac)
        {
            db.Entry(ac).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Account ac = db.Accounts.Find(id);
            if (ac != null)
                db.Accounts.Remove(ac);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

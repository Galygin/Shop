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
    public class SQLPurchaseRepository : IRepository<Purchase>
    {
        private ProductContext db;

        public SQLPurchaseRepository()
        {
            this.db = new ProductContext();
        }

        public IEnumerable<Purchase> GetList()
        {
            return db.Purchases;
        }

        public Purchase Get(int id)
        {
            return db.Purchases.Find(id);
        }

        public void Create(Purchase ps)
        {
            db.Purchases.Add(ps);
        }

        public void Update(Purchase ps)
        {
            db.Entry(ps).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Purchase ps = db.Purchases.Find(id);
            if (ps != null)
                db.Purchases.Remove(ps);
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

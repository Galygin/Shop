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
    public class SQLRecallRepository : IRepository<Recall>
    {
        private ProductContext db;

        public SQLRecallRepository()
        {
            this.db = new ProductContext();
        }

        public IEnumerable<Recall> GetList()
        {
            return db.Recalls;
        }

        public Recall Get(int id)
        {
            return db.Recalls.Find(id);
        }

        public void Create(Recall rec)
        {
            db.Recalls.Add(rec);
        }

        public void Update(Recall rec)
        {
            db.Entry(rec).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Recall rec = db.Recalls.Find(id);
            if (rec != null)
                db.Recalls.Remove(rec);
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

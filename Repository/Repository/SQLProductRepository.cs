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
    public class SQLProductRepository : IRepository<Product>
    {
        private ProductContext db;

        public SQLProductRepository()
        {
            this.db = new ProductContext();
        }

        public IEnumerable<Product> GetList()
        {
            return db.Products;
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public void Create(Product p)
        {
            db.Products.Add(p);
        }

        public void Update(Product p)
        {
            db.Entry(p).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product p = db.Products.Find(id);
            if (p != null)
                db.Products.Remove(p);
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

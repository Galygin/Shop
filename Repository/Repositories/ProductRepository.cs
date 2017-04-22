using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Repositories;
using Repository.Interfaces;
using Repository.Context;
using Domain;

namespace Repository.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        ProductContext db;
        public ProductRepository(ProductContext context) : base(context)
        {
            db = context;
        }

        public override void Delete(int id)
        {
            db.Products.Find(id).Removed = true;
        }
    }
}

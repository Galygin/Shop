using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository.Interfaces;
using Repository.Context;

namespace Repository.Repositories
{
    public class PurchaseRepository: RepositoryBase<Purchase>, IPurchaseRepository
    {
        ProductContext db;
        public PurchaseRepository(ProductContext context) : base(context)
        {
            db = context;
        }
    }
}

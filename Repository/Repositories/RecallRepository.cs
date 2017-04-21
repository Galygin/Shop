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
    public class RecallRepository : RepositoryBase<Recall>, IRecallRepository
    {
        ProductContext db;
        public RecallRepository(ProductContext context) : base(context)
        {
            db = context;
        }
    }
}

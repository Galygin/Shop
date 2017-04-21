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
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        ProductContext db;
        public AccountRepository(ProductContext context) : base(context)
        {
            db = context;
        }
    }
}

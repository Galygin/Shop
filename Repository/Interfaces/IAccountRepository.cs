using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository.Interfaces;
using Repository.Context;

namespace Repository.Interfaces
{
    interface IAccountRepository : IRepositoryBase<Account>
    {
    }
}

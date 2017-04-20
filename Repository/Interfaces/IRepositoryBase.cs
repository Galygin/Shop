using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Repository.Interfaces
{
    interface IRepositoryBase<T>
    {
        void Add(T Entity);
        void Edit(T Entity);
        void Delete(int id);
        T Get(int id);
        IEnumerable<T> Entities();
        void Save();
    }
}
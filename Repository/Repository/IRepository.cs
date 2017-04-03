using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Repository.Repository
{
    public interface IRepository<Boss> : IDisposable 
    {
        IEnumerable<Boss> GetList(); // получение всех объектов
        Boss Get(int id); // получение одного объекта по id
        void Create(Boss item); // создание объекта
        void Update(Boss item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}

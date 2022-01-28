using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Nix_proj.Repository
{
    interface IRepository<T>
    {
        IEnumerable<T> GetItemList(); // получение всех объектов
        T GetItem(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}

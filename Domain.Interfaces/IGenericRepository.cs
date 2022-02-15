using System;
using System.Collections.Generic;
using DomainCore;
using System.Linq.Expressions;

namespace DomainInterfaces

{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(); // получение всех объектов
        TEntity GetById(Guid id); // получение одного объекта по id
        IEnumerable<TEntity> GetByPredicate(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity); // создание объекта
        void Update(TEntity entity); // обновление объекта
        void DeleteById(Guid id); // удаление объекта по id
        bool DeleteEntity(TEntity entity);
        void Save();  // сохранение изменений

    }
}
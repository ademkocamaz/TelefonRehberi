using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TelefonRehberi.Core.Entities;

namespace TelefonRehberi.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetAll();
        //T Get(Expression<Func<T, bool>> filter);
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

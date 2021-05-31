using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    interface IProductRepositoryBase<T>
    {
        void Add(List<T> entities ,T entity);
        void Update(List<T> entities,T entity);
        void Delete(T entity);
        T Get(T entity);
        List<T> GetAll(T entity);
    }
}

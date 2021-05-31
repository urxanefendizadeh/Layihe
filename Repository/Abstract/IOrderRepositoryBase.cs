using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    interface IOrderRepositoryBase<T>
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(T entity);
        List<T> GetAll(T entity);

    }
}

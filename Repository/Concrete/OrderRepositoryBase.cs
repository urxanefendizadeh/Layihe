using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    class OrderRepositoryBase<TEntity> : IOrderRepositoryBase<TEntity>
         where TEntity : class, new()
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

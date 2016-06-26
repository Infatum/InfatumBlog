using System.Collections.Generic;
using DataAccessLayer.Entities.Abstract;

namespace DataAccessLayer.AbstractLayer
{
    interface IDataAccesRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        TKey Insert(TEntity entity);
        bool Update(TEntity entity);
        int Upsert(TEntity entity);

        int GetCount();

        TEntity GetById(TKey id);
        IList<TEntity> GetAll();
    }
}

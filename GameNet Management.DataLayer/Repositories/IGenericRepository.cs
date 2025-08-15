using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GameNet_Management.DataLayer.Repositories
{
    public interface IGenericRepository<EntityType> where EntityType : class
    {
        void Delete(EntityType entity);
        void Delete(object entityID);
        IEnumerable<EntityType> Get(Expression<Func<EntityType, bool>> where = null);
        EntityType GetByID(object entityID);
        void Insert(EntityType entity);
        void Update(EntityType entity);
    }
}
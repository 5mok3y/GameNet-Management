using GameNet_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameNet_Management.DataLayer.Service
{
    public class GenericRepository<EntityType> : IGenericRepository<EntityType> where EntityType : class
    {
        private GameNetDBEntities _db;
        protected DbSet<EntityType> _dbSet;

        public GenericRepository(GameNetDBEntities db)
        {
            _db = db;
            _dbSet = db.Set<EntityType>();
        }

        public virtual IEnumerable<EntityType> Get(Expression<Func<EntityType, bool>> where = null)
        {
            IQueryable<EntityType> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public virtual EntityType GetByID(object entityID)
        {
            return _dbSet.Find(entityID);
        }

        public virtual void Insert(EntityType entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(EntityType entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(EntityType entity)
        {
            _dbSet.Remove(entity);
        }
        public virtual void Delete(object entityID)
        {
            EntityType entity = GetByID(entityID);
            Delete(entity);
        }

    }
}

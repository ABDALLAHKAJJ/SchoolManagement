using SchoolManagement.Core.Abstracts;
using SchoolManagement.EntityFramework.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagement.EntityFramework.Repository
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly SchoolManagementContext _db;

        public EntityRepository(SchoolManagementContext db)
        {
            _db = db;
        }

        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                _db.Add(entity);
                _db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _db.Remove(entity);
                _db.SaveChanges();
            }
        }

        public TEntity Get(int id)
        {
            return _db.Find<TEntity>(id);
        }

        public List<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            if (entity != null)
            {
                _db.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
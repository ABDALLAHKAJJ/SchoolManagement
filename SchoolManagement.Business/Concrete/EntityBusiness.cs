using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Libraries.Core.Absrtacts;
using System.Collections.Generic;

namespace SchoolManagement.Business.Concrete
{
    public class EntityBusiness<TEntity> : IEntityBusiness<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _entityRepository;

        public EntityBusiness(IEntityRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                _entityRepository.Add(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _entityRepository.Delete(entity);
            }
        }

        public TEntity Get(int id)
        {
            return _entityRepository.Get(id);
        }

        public List<TEntity> GetAll()
        {
            return _entityRepository.GetAll();
        }

        public void Update(TEntity entity)
        {
            _entityRepository.Update(entity);
        }
    }
}
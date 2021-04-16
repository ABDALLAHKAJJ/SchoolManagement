using System;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Libraries.Core.Abstracts;
using SchoolManagement.Libraries.Core.Results;
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

        public IResult Add(TEntity entity)
        {
            if (entity != null)
            {
                _entityRepository.Add(entity);
                return new SuccessResult("Success");
            }
            else
            {
                return new ErrorResult("Error");
            }
        }

        public IResult Delete(TEntity entity)
        {
            if (entity != null)
            {
                _entityRepository.Delete(entity);
                return new SuccessResult("Success");
            }
            else
            {
                return new ErrorResult("Error");
            }
        }

        public IDataResult<TEntity> Get(int id)
        {
            var result = _entityRepository.Get(id);
            if (result != null)
            {
                return new SuccessDataResult<TEntity>(result, "success");
            }
            else
            {
                return new ErrorDataResult<TEntity>("Error");
            }
        }

        public IDataResult<List<TEntity>> GetAll()
        {
            var result = _entityRepository.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<TEntity>>(result, "success");
            }
            else
            {
                return new ErrorDataResult<List<TEntity>>("Error");
            }
        }

        public IResult Update(TEntity entity)
        {
            if (entity != null)
            {
                _entityRepository.Update(entity);
                return new SuccessResult("Success");
            }
            else
            {
                return new ErrorResult("Error");
            }
        }
    }
}
using SchoolManagement.Core.Abstracts;
using System.Collections.Generic;

namespace SchoolManagement.Business.Interfaces
{
    public interface IEntityBusiness<TEntity> where TEntity : class, IEntity, new()
    {
        TEntity Get(int id);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
using System.Collections.Generic;
using SchoolManagement.Libraries.Core.Abstracts;

namespace SchoolManagement.Data.Abstracts
{
    public interface IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        TEntity Get(int id);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
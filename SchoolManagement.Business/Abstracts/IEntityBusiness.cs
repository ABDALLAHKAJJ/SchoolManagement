using System.Collections.Generic;
using SchoolManagement.Libraries.Core.Abstracts;

namespace SchoolManagement.Business.Abstracts
{
    public interface IEntityBusiness<TEntity> where TEntity : class, IEntity, new()
    {
        IDataResult<TEntity> Get(int id);

        IDataResult<List<TEntity>> GetAll();

        IResult Add(TEntity entity);

        IResult Update(TEntity entity);

        IResult Delete(TEntity entity);
    }
}
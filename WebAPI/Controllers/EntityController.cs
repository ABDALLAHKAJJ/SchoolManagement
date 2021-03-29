using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Libraries.Core.Absrtacts;

namespace WebAPI.Controllers
{
    public class EntityController<TEntity> : ControllerBase
        where TEntity : class, IEntity, new()
    {
        private readonly IEntityBusiness<TEntity> _entityBusiness;

        public EntityController(IEntityBusiness<TEntity> entityBusiness)
        {
            _entityBusiness = entityBusiness;
        }

        [HttpGet("Get/{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_entityBusiness.Get(id));
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_entityBusiness.GetAll());
        }

        [HttpPost]
        public void Post([FromBody] TEntity entity)
        {
            _entityBusiness.Add(entity);
        }

        [HttpPut()]
        public void Put([FromBody] TEntity entity)
        {
            _entityBusiness.Update(entity);
        }

        [HttpDelete()]
        public void Delete(TEntity entity)
        {
            _entityBusiness.Delete(entity);
        }
    }
}
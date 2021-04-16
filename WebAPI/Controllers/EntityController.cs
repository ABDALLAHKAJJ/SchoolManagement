using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Libraries.Core.Abstracts;
using SchoolManagement.Libraries.Core.Extension;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController<TEntity> : ControllerBase
        where TEntity : class, IEntity, new()
    {
        private readonly IEntityBusiness<TEntity> _entityBusiness;
        private readonly ILoggingManager _logger;

        public EntityController(IEntityBusiness<TEntity> entityBusiness, ILoggingManager logger)
        {
            _entityBusiness = entityBusiness;
            _logger = logger;
        }

        [HttpGet("Get/{id}")]
        public ActionResult Get(int id)
        {
            _logger.LogInfo($"{HttpContext.Request.Path}:Request started");

            var result = _entityBusiness.Get(id);
            if (result.Success)
            {
                _logger.LogInfo($"{HttpContext.Request.Path}:Request Ended with Response: " +
                                $"Data: {result.Data.ToJson()}, " +
                                $"Message: {result.Message}, " +
                                $"Success: {result.Success} ");
                return Ok(result);
            }
            else
            {
                _logger.LogError($"No Result Found");
                return NotFound();
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            _logger.LogInfo($"{HttpContext.Request.Path}:Request started");

            var result = _entityBusiness.GetAll();
            if (result.Success)
            {
                _logger.LogInfo($"{HttpContext.Request.Path}:Request Ended with Response: " +
                                $"Data: {result.Data.ToJson()}, " +
                                $"Message: {result.Message}, " +
                                $"Success: {result.Success} ");
                return Ok(result);
            }
            else
            {
                _logger.LogError($"No Result Found");
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] TEntity entity)
        {
            _logger.LogInfo($"{HttpContext.Request.Path}:Work started");

            var result = _entityBusiness.Add(entity);
            if (result.Success)
            {
                _logger.LogInfo($"{HttpContext.Request.Path}:Work Ended with Response: " +
                                $"Message: {result.Message}, " +
                                $"Success: {result.Success} ");
                return Ok(result);
            }
            else
            {
                _logger.LogError($"Couldn't be added");
                return BadRequest();
            }
        }

        [HttpPut()]
        public ActionResult Put([FromBody] TEntity entity)
        {
            _logger.LogInfo($"{HttpContext.Request.Path}:Work started");

            var result = _entityBusiness.Update(entity);
            if (result.Success)
            {
                _logger.LogInfo($"{HttpContext.Request.Path}:Work Ended with Response: " +
                                $"Message: {result.Message}, " +
                                $"Success: {result.Success} ");
                return Ok(result);
            }
            else
            {
                _logger.LogError($"Couldn't be updated");
                return BadRequest();
            }
        }

        [HttpDelete()]
        public ActionResult Delete(TEntity entity)
        {
            _logger.LogInfo($"{HttpContext.Request.Path}:Work started");

            var result = _entityBusiness.Delete(entity);
            if (result.Success)
            {
                _logger.LogInfo($"{HttpContext.Request.Path}:Work Ended with Response: " +
                                $"Message: {result.Message}, " +
                                $"Success: {result.Success} ");
                return Ok(result);
            }
            else
            {
                _logger.LogError($"Couldn't be deleted");
                return BadRequest();
            }
        }
    }
}
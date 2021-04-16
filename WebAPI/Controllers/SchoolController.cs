using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Entities;
using SchoolManagement.Libraries.Core.Abstracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : EntityController<School>
    {
        public SchoolController(ISchoolBusiness schoolBusiness, ILoggingManager logger) : base(schoolBusiness, logger)
        {
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Entities;
using SchoolManagement.Libraries.Core.Abstracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : EntityController<Teacher>
    {
        public TeacherController(ITeacherBusiness teacherBusiness, ILoggingManager logger) : base(teacherBusiness, logger)
        {
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Entities;
using SchoolManagement.Libraries.Core.Abstracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : EntityController<Student>
    {
        public StudentController(IStudentBusiness studentBusiness, ILoggingManager logger) : base(studentBusiness, logger)
        {
        }
    }
}
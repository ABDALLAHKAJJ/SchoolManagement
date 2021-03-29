using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : EntityController<Teacher>
    {
        private readonly ITeacherBusiness _teacherBusiness;

        public TeacherController(ITeacherBusiness teacherBusiness) : base(teacherBusiness)
        {
            _teacherBusiness = teacherBusiness;
        }
    }
}
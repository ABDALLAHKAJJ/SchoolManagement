using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : EntityController<Teacher>
    {
        private ITeacherBusiness _teacherBusiness;

        public TeacherController(ITeacherBusiness teacherBusiness) : base(teacherBusiness)
        {
            _teacherBusiness = teacherBusiness;
        }
    }
}
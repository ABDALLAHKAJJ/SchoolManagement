using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;

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
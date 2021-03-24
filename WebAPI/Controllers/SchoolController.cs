using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : EntityController<School>
    {
        private readonly ISchoolBusiness _schoolBusiness;

        public SchoolController(ISchoolBusiness schoolBusiness) : base(schoolBusiness)
        {
            _schoolBusiness = schoolBusiness;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Entities;

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
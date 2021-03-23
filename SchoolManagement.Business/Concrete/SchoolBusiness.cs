using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework.Interfaces;

namespace SchoolManagement.Business.Concrete
{
    public class SchoolBusiness : EntityBusiness<School>, ISchoolBusiness
    {
        private readonly ISchoolRepository _sr;

        public SchoolBusiness(ISchoolRepository sr) : base(sr)
        {
            _sr = sr;
        }
    }
}
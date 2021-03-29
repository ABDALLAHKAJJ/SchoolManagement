using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

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
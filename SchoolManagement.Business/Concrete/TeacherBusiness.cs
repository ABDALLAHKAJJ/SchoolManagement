using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Business.Concrete
{
    public class TeacherBusiness : EntityBusiness<Teacher>, ITeacherBusiness
    {
        private readonly ITeacherRepository _tr;

        public TeacherBusiness(ITeacherRepository tr) : base(tr)
        {
            _tr = tr;
        }
    }
}
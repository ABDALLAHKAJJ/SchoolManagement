using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework.Interfaces;

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
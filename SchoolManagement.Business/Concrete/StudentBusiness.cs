using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework.Interfaces;

namespace SchoolManagement.Business.Concrete
{
    public class StudentBusiness : EntityBusiness<Student>, IStudentBusiness
    {
        private readonly IStudentRepository _sr;

        public StudentBusiness(IStudentRepository sr) : base(sr)
        {
            _sr = sr;
        }
    }
}
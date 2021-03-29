using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

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
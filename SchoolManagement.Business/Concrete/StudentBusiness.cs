using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Business.Concrete
{
    public class StudentBusiness : EntityBusiness<Student>, IStudentBusiness
    {
        public StudentBusiness(IStudentRepository sr) : base(sr)
        {
        }
    }
}
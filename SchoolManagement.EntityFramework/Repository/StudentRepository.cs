using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data.Repository
{
    public class StudentRepository : EntityRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolManagementContext db) : base(db)
        {
        }
    }
}
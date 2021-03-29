using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data.Repository
{
    public class StudentRepository : EntityRepository<Student>, IStudentRepository
    {
        private readonly SchoolManagementContext _db;

        public StudentRepository(SchoolManagementContext db) : base(db)
        {
            _db = db;
        }
    }
}
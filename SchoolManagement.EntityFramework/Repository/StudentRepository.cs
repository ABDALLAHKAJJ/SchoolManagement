using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework.Interfaces;

namespace SchoolManagement.EntityFramework.Repository
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
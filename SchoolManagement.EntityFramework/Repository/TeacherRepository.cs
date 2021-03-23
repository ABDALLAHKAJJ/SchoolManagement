using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework.Interfaces;

namespace SchoolManagement.EntityFramework.Repository
{
    public class TeacherRepository : EntityRepository<Teacher>, ITeacherRepository
    {
        private readonly SchoolManagementContext _db;

        public TeacherRepository(SchoolManagementContext db) : base(db)
        {
            _db = db;
        }
    }
}
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data.Repository
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
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data.Repository
{
    public class TeacherRepository : EntityRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolManagementContext db) : base(db)
        {
        }
    }
}
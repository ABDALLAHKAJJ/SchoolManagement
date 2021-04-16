using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data.Repository
{
    public class SchoolRepository : EntityRepository<School>, ISchoolRepository
    {
        public SchoolRepository(SchoolManagementContext db) : base(db)
        {
        }
    }
}
using SchoolManagement.Data.Abstracts;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data.Repository
{
    public class SchoolRepository : EntityRepository<School>, ISchoolRepository
    {
        private readonly SchoolManagementContext _db;

        public SchoolRepository(SchoolManagementContext db) : base(db)
        {
            _db = db;
        }
    }
}
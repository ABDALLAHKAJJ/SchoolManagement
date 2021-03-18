using SchoolManagement.Core.Interfaces;
using SchoolManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.EntityFramework
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
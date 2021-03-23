﻿using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework.Interfaces;

namespace SchoolManagement.EntityFramework.Repository
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
using SchoolManagement.Core.Interfaces;
using SchoolManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.EntityFramework
{
    public class StudentReopsitory : EntityRepository<Student>, IStudentRepository
    {
        private readonly SchoolManagementContext _db;

        public StudentReopsitory(SchoolManagementContext db) : base(db)
        {
            _db = db;
        }
    }
}
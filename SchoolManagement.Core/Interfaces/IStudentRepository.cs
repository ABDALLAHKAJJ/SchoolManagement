using SchoolManagement.Core.Abstracts;
using SchoolManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Core.Interfaces
{
    internal interface IStudentRepository : IEntityRepository<Student>
    {
    }
}
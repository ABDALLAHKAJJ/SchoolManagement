using SchoolManagement.Core.Abstracts;
using SchoolManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Interfaces
{
    public interface IStudentBusiness : IEntityRepository<Student>

    {
    }
}
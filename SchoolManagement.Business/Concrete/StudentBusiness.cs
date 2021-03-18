using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    public class StudentBusiness : EntityBusiness<Student>, IStudentBusiness<Student>
    {
        private readonly StudentReopsitory _sr;

        public StudentBusiness(StudentReopsitory sr) : base(sr)
        {
            _sr = sr;
        }
    }
}
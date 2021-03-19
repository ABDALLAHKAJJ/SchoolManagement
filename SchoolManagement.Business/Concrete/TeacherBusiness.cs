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
    public class TeacherBusiness : EntityBusiness<Teacher>, ITeacherBusiness
    {
        private readonly TeacherRepository _tr;

        public TeacherBusiness(TeacherRepository tr) : base(tr)
        {
            _tr = tr;
        }
    }
}
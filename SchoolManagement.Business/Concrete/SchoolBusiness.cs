using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Interfaces;
using SchoolManagement.Core.Models;
using SchoolManagement.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    public class SchoolBusiness : EntityBusiness<School>, ISchoolBusiness<School>
    {
        private readonly ISchoolRepository _sr;

        public SchoolBusiness(ISchoolRepository sr) : base(sr)
        {
            _sr = sr;
        }
    }
}
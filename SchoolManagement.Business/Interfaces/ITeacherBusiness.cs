using SchoolManagement.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Interfaces
{
    public interface ITeacherBusiness<Teacher> : IEntityRepository<Teacher>
        where Teacher : class, IEntity, new()
    {
    }
}
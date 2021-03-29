using SchoolManagement.Data.Entities;
using System.Collections.Generic;

namespace SchoolManagement.Automation.HangFire.JobAbstracts
{
    public interface IJobAllStudentsRetriever
    {
        List<Student> AllStudentsRetrieve();
    }
}
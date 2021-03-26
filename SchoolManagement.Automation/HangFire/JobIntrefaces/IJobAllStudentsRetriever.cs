using SchoolManagement.Core.Models;
using System.Collections.Generic;

namespace SchoolManagement.Automation.HangFire.JobIntrefaces
{
    public interface IJobAllStudentsRetriever
    {
        List<Student> AllStudentsRetrieve();
    }
}
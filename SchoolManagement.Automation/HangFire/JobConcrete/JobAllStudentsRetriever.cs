using SchoolManagement.Automation.HangFire.JobIntrefaces;
using SchoolManagement.Business.Interfaces;
using SchoolManagement.Core.Models;
using System.Collections.Generic;

namespace SchoolManagement.Automation.HangFire.JobConcrete
{
    public class JobAllStudentsRetriever : IJobAllStudentsRetriever
    {
        private readonly IStudentBusiness _studentBusiness;

        public JobAllStudentsRetriever(IStudentBusiness studentBusiness)
        {
            _studentBusiness = studentBusiness;
        }

        public List<Student> AllStudentsRetrieve()
        {
            return _studentBusiness.GetAll();
        }
    }
}
using SchoolManagement.Automation.HangFire.JobAbstracts;
using SchoolManagement.Business.Abstracts;
using SchoolManagement.Data.Entities;
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
            return _studentBusiness.GetAll().Data;
        }
    }
}
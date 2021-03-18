using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.EntityFramework
{
    public class SchoolManagementContext : DbContext
    {
        //private string connectionString = @"Server=DESKTOP-6E0MHSD\APO; Database= SchoolManagement; Trusted_Connection=True;";

        public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options) : base(options)
        {
        }

        private DbSet<School> Schools { get; set; }
        private DbSet<Student> Students { get; set; }
        private DbSet<Teacher> Teachers { get; set; }
    }
}
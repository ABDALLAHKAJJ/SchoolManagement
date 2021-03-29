using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data
{
    public class SchoolManagementContext : DbContext
    {
        //private string connectionString = @"Server=DESKTOP-6E0MHSD\APO; Database= SchoolManagement; Trusted_Connection=True;";

        public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
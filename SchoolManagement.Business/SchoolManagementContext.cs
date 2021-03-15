﻿using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business
{
    public class SchoolManagementContext : DbContext
    {
        private string connectionString = @"Server = DESKTOP-6E0MHSD\APO; Database= SchoolManagement; Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        private DbSet<School> Schools { get; set; }
        private DbSet<Student> Students { get; set; }
        private DbSet<Teacher> Teachers { get; set; }
    }
}
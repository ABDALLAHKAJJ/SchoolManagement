using SchoolManagement.Libraries.Core.Abstracts;
using SchoolManagement.Libraries.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Data.Entities
{
    public class Student : Entity, IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public int Grade { get; set; }
    }
}
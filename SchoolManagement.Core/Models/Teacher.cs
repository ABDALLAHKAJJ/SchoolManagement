using SchoolManagement.Core.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Core.Models
{
    public class Teacher : Entity, IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public string Field { get; set; }
    }
}
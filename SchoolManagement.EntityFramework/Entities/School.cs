using SchoolManagement.Libraries.Core.Abstracts;
using SchoolManagement.Libraries.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Data.Entities
{
    public class School : Entity, IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
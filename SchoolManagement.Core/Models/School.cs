using SchoolManagement.Core.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Core.Models
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
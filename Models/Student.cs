using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class Student 
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        public string MiddleName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(2)]
        public int GradeLevel { get; set; }
        
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
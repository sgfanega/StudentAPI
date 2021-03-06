using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Dtos
{
    public class StudentUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [MaxLength(50)]
        public string MiddleName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Range(1, 12)]
        public int GradeLevel { get; set;}

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
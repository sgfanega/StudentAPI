namespace StudentAPI.Dtos
{
    public class StudentReadDto
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int GradeLevel { get; set; }
    }
}
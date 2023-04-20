namespace OpenGrade.Models
{
	public class Course
	{
        public Guid courseId { get; set; }
        public Guid qualificationId { get; set; }
        public string Title { get; set; }
        public Guid subjectId { get; set; }
    }
}

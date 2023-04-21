namespace OpenGrade.Models
{
	public class Courses
	{
        public Guid courseId { get; set; }
        public Guid qualificationId { get; set; }
        public string Title { get; set; }
        public Guid subjectId { get; set; }
    }
}

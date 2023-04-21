namespace OpenGrade.Models
{
	public class Grades
	{
        public Guid gradeId { get; set; }
        public string Grade { get; set; }
        public int Value { get; set; }
        public int Order { get; set; }
        public Guid courseId { get; set; }
    }
}

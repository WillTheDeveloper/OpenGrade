namespace OpenGrade.Models
{
	public class Grade
	{
        public Guid gradeId { get; set; }
        public string Gradee { get; set; }
        public string Value { get; set; }
        public int Order { get; set; }
        public Guid courseId { get; set; }
    }
}

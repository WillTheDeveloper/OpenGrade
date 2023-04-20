using OpenGrade.Models;

namespace OpenGrade.Data
{
	public interface ICourseData
	{
		Task<IEnumerable<Course>> TestMethod();
		Task<IEnumerable<Course>> CourseBySubject(string subjectName);
	}
}

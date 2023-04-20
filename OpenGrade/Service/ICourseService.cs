using OpenGrade.Models;

namespace OpenGrade.Service
{
	public interface ICourseService
	{
		Task<IEnumerable<Course>> TestMethod();
		Task<IEnumerable<Course>> CourseBySubject(string subjectName);
	}
}

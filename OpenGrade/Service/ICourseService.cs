using OpenGrade.Models;

namespace OpenGrade.Service
{
	public interface ICourseService
	{
		Task<IEnumerable<Course>> TestMethod();
		Task<IEnumerable<Course>> CourseBySubject(string subjectName);
		Task<IEnumerable<Course>> GetAllCourses();
		Task<Course> GetCourseByGuid(Guid courseGuid);
		Task<IEnumerable<Grade>> GetCourseGradesByGuid(Guid courseId);
	}
}

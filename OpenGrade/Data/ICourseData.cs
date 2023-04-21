using OpenGrade.Models;

namespace OpenGrade.Data
{
	public interface ICourseData
	{
		Task<IEnumerable<Course>> TestMethod();
		Task<IEnumerable<Course>> CourseBySubject(string subjectName);
		Task<IEnumerable<Course>> GetAllCourses();
		Task<Course> GetCourseByGuid(Guid courseId);
		Task<IEnumerable<Grade>> GetCourseGradesByGuid(Guid courseId);
	}
}

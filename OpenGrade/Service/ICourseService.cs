using OpenGrade.Models;

namespace OpenGrade.Service
{
	public interface ICourseService
	{
		Task<IEnumerable<Courses>> TestMethod();
		Task<IEnumerable<Courses>> CourseBySubject(string subjectName);
		Task<IEnumerable<Courses>> GetAllCourses();
		Task<Courses> GetCourseByGuid(Guid courseGuid);
		Task<IEnumerable<Grades>> GetCourseGradesByGuid(Guid courseId);
	}
}

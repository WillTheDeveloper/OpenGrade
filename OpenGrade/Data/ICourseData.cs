using OpenGrade.Models;

namespace OpenGrade.Data
{
	public interface ICourseData
	{
		Task<IEnumerable<Courses>> TestMethod();
		Task<IEnumerable<Courses>> CourseBySubject(string subjectName);
		Task<IEnumerable<Courses>> GetAllCourses();
		Task<Courses> GetCourseByGuid(Guid courseId);
		Task<IEnumerable<Grades>> GetCourseGradesByGuid(Guid courseId);
	}
}

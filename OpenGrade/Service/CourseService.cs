using OpenGrade.Data;
using OpenGrade.Models;
using System.Collections;

namespace OpenGrade.Service
{
	public class CourseService : ICourseService
	{
		private readonly ICourseData _courseData;

		public CourseService(ICourseData courseData)
		{
			_courseData = courseData;
		}

		public async Task<IEnumerable<Courses>> TestMethod()
		{
			return await _courseData.TestMethod();
		}

		public async Task<IEnumerable<Courses>> CourseBySubject(string subjectName)
		{
			return await _courseData.CourseBySubject(subjectName);
		}

		public async Task<IEnumerable<Courses>> GetAllCourses()
		{
			return await _courseData.GetAllCourses();
		}

		public async Task<Courses> GetCourseByGuid(Guid courseId)
		{
			return await _courseData.GetCourseByGuid(courseId);
		}

		public async Task<IEnumerable<Grades>> GetCourseGradesByGuid(Guid courseId)
		{
			return await _courseData.GetCourseGradesByGuid(courseId);
		}
	}
}

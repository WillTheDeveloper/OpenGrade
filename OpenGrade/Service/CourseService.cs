using OpenGrade.Data;
using OpenGrade.Models;
using System.Collections;

namespace OpenGrade.Service
{
	public class CourseService : ICourseService
	{
		readonly ICourseData _courseData;

		public CourseService(ICourseData courseData)
		{
			_courseData = courseData;
		}

		public async Task<IEnumerable<Course>> TestMethod()
		{
			return await _courseData.TestMethod();
		}

		public async Task<IEnumerable<Course>> CourseBySubject(string subjectName)
		{
			return await _courseData.CourseBySubject(subjectName);
		}

		public async Task<IEnumerable<Course>> GetAllCourses()
		{
			return await _courseData.GetAllCourses();
		}

		public async Task<Course> GetCourseByGuid(Guid courseId)
		{
			return await _courseData.GetCourseByGuid(courseId);
		}

		public async Task<IEnumerable<Grade>> GetCourseGradesByGuid(Guid courseId)
		{
			return await _courseData.GetCourseGradesByGuid(courseId);
		}
	}
}

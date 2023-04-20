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
	}
}

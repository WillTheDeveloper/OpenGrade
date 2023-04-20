using Dapper;
using OpenGrade.Models;
using System.Data;

namespace OpenGrade.Data
{
	public class CourseData : ICourseData
	{
		readonly Context _context;

        public CourseData(Context context)
        {
            _context = context;
        }

		public async Task<IEnumerable<Course>> TestMethod()
		{
			var result = new List<Course>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				var parameters = new DynamicParameters();
				result = await connection.QueryAsync<Course>("pGetAllCourses", commandType: CommandType.StoredProcedure, param: parameters);
			}
			return result;
		}

		public async Task<IEnumerable<Course>> CourseBySubject(string SubjectName)
		{
			var result = new List<Course>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Course>($"SELECT * FROM Courses c JOIN Subjects s ON s.subjectId = c.SubjectId WHERE s.Name = '{SubjectName}'");
			}
			return result;
		}

		public async Task<IEnumerable<Course>> GetAllCourses()
		{
			var result = new List<Course>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Course>("SELECT * FROM Courses");
			}
			return result;
		}
	}
}

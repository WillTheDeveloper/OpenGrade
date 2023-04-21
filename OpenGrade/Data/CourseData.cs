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

		public async Task<IEnumerable<Courses>> TestMethod()
		{
			var result = new List<Courses>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				var parameters = new DynamicParameters();
				result = await connection.QueryAsync<Courses>("pGetAllCourses", commandType: CommandType.StoredProcedure, param: parameters);
			}
			return result;
		}

		public async Task<IEnumerable<Courses>> CourseBySubject(string SubjectName)
		{
			var result = new List<Courses>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Courses>($"SELECT * FROM Courses c JOIN Subjects s ON s.subjectId = c.SubjectId WHERE s.Name = '{SubjectName}'");
			}
			return result;
		}

		public async Task<IEnumerable<Courses>> GetAllCourses()
		{
			var result = new List<Courses>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Courses>("SELECT * FROM Courses");
			}
			return result;
		}

		public async Task<Courses> GetCourseByGuid(Guid courseId)
		{
			var result = new Courses();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryFirstAsync<Courses>($"SELECT * FROM Courses WHERE courseId = '{courseId}'");
			}
			return result;
		}

		public async Task<IEnumerable<Grades>> GetCourseGradesByGuid(Guid courseId)
		{
			var result = new List<Grades>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Grades>($"SELECT * FROM Grades g JOIN Courses c ON c.courseId = g.courseId WHERE c.courseId = '{courseId}' ORDER BY g.[Order] ASC");
			}
			return result;
		}
	}
}

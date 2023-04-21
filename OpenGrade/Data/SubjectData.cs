using Dapper;
using OpenGrade.Models;

namespace OpenGrade.Data
{
	public class SubjectData : ISubjectData
	{
		readonly Context _context;

		public SubjectData(Context context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Subject>> GetAllSubjects()
		{
			var result = new List<Subject>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Subject>($"SELECT * FROM Subjects");
			}
			return result;
		}

		public async Task<Subject> GetSubjectByName(string subjectName)
		{
			var result = new Subject();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryFirstAsync<Subject>($"SELECT * FROM Subjects WHERE Name = '{subjectName}'");
			}
			return result;
		}

		public async Task<Subject> GetSubjectByGuid(Guid subjectGuid)
		{
			var result = new Subject();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryFirstAsync<Subject>($"SELECT * FROM Subjects WHERE subjectId = '{subjectGuid}'");
			}
			return result;
		}

		public async Task<IEnumerable<Course>> GetCoursesBySubjectName(string subjectName)
		{
			var result = new List<Course>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Course>($"SELECT * FROM Courses c JOIN Subjects s ON s.subjectId = c.SubjectId WHERE s.Name = '{subjectName}'");
			}
			return result;
		}
	}
}

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

		public async Task<IEnumerable<Subjects>> GetAllSubjects()
		{
			var result = new List<Subjects>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Subjects>($"SELECT * FROM Subjects");
			}
			return result;
		}

		public async Task<Subjects> GetSubjectByName(string subjectName)
		{
			var result = new Subjects();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryFirstAsync<Subjects>($"SELECT * FROM Subjects WHERE Name = '{subjectName}'");
			}
			return result;
		}

		public async Task<Subjects> GetSubjectByGuid(Guid subjectGuid)
		{
			var result = new Subjects();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryFirstAsync<Subjects>($"SELECT * FROM Subjects WHERE subjectId = '{subjectGuid}'");
			}
			return result;
		}

		public async Task<IEnumerable<Courses>> GetCoursesBySubjectName(string subjectName)
		{
			var result = new List<Courses>().AsEnumerable();
			using (var connection = _context.dbConnection())
			{
				result = await connection.QueryAsync<Courses>($"SELECT * FROM Courses c JOIN Subjects s ON s.subjectId = c.SubjectId WHERE s.Name = '{subjectName}'");
			}
			return result;
		}
	}
}

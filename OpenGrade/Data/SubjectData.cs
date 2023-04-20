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
	}
}

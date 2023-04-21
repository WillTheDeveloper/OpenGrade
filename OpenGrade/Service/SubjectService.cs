using OpenGrade.Data;
using OpenGrade.Models;

namespace OpenGrade.Service
{
	public class SubjectService : ISubjectService
	{
		readonly ISubjectData _subjectData;

		public SubjectService(ISubjectData subjectData)
		{
			_subjectData = subjectData;
		}
		
		public async Task<IEnumerable<Subject>> GetAllSubjects()
		{
			return await _subjectData.GetAllSubjects();
		}

		public Task<Subject> GetSubjectByGuid(Guid subjectId)
		{
			throw new NotImplementedException();
		}

		public Task<Subject> GetSubjectByName(string subjectName)
		{
			throw new NotImplementedException();
		}
	}
}

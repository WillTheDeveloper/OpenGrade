using OpenGrade.Models;

namespace OpenGrade.Service
{
	public interface ISubjectService
	{
		Task<IEnumerable<Subjects>> GetAllSubjects();
		Task<Subjects> GetSubjectByGuid(Guid subjectId);
		Task<Subjects> GetSubjectByName(string subjectName);
	}
}

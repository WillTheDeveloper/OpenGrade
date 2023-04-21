using OpenGrade.Models;

namespace OpenGrade.Service
{
	public interface ISubjectService
	{
		Task<IEnumerable<Subject>> GetAllSubjects();
		Task<Subject> GetSubjectByGuid(Guid subjectId);
		Task<Subject> GetSubjectByName(string subjectName);
	}
}

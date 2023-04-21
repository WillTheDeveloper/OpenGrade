using OpenGrade.Models;

namespace OpenGrade.Data
{
	public interface ISubjectData
	{
		Task<IEnumerable<Subject>> GetAllSubjects();
		Task<Subject> GetSubjectByName(string subjectName);
		Task<Subject> GetSubjectByGuid(Guid subjectGuid);
	}
}

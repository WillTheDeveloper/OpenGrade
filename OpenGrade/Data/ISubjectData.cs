using OpenGrade.Models;

namespace OpenGrade.Data
{
	public interface ISubjectData
	{
		Task<IEnumerable<Subjects>> GetAllSubjects();
		Task<Subjects> GetSubjectByName(string subjectName);
		Task<Subjects> GetSubjectByGuid(Guid subjectGuid);
	}
}

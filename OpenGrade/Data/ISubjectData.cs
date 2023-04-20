using OpenGrade.Models;

namespace OpenGrade.Data
{
	public interface ISubjectData
	{
		Task<IEnumerable<Subject>> GetAllSubjects();
	}
}

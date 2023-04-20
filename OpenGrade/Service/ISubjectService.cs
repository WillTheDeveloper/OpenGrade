using OpenGrade.Models;

namespace OpenGrade.Service
{
	public interface ISubjectService
	{
		Task<IEnumerable<Subject>> GetAllSubjects();
	}
}

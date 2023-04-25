using OpenGrade.Models;

namespace OpenGrade.Service;

public interface IQualificationService
{
    Task<IEnumerable<Qualifications>> GetAllQualifications();
    Task<Qualifications> GetQualificationByGuid(Guid qualificationId);
    Task<IEnumerable<Courses>> GetQualificationCoursesByGuid(Guid qualificationId);
}
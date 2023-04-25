using OpenGrade.Models;

namespace OpenGrade.Data;

public interface IQualificationData
{
    Task<IEnumerable<Qualifications>> GetAllQualifications();
    Task<Qualifications> GetQualificationByGuid(Guid qualificationId);
    Task<IEnumerable<Courses>> GetQualificationCoursesByGuid(Guid qualificationId);
}
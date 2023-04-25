using OpenGrade.Data;
using OpenGrade.Models;

namespace OpenGrade.Service;

public class QualificationService : IQualificationService
{
    private readonly IQualificationData _qualificationData;

    public QualificationService(IQualificationData qualificationData)
    {
        _qualificationData = qualificationData;
    }

    public async Task<IEnumerable<Qualifications>> GetAllQualifications()
    {
        return await _qualificationData.GetAllQualifications();
    }

    public async Task<Qualifications> GetQualificationByGuid(Guid qualificationId)
    {
        return await _qualificationData.GetQualificationByGuid(qualificationId);
    }

    public async Task<IEnumerable<Courses>> GetQualificationCoursesByGuid(Guid qualificationId)
    {
        return await _qualificationData.GetQualificationCoursesByGuid(qualificationId);
    }
}
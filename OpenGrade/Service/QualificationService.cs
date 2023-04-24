using OpenGrade.Data;

namespace OpenGrade.Service;

public class QualificationService : IQualificationService
{
    private readonly IQualificationData _qualificationData;

    public QualificationService(IQualificationData qualificationData)
    {
        _qualificationData = qualificationData;
    }
}
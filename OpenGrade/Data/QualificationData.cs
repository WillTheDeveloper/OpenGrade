using Dapper;
using OpenGrade.Models;

namespace OpenGrade.Data;

public class QualificationData : IQualificationData
{
    readonly Context _context;

    public QualificationData(Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Qualifications>> GetAllQualifications()
    {
        var result = new List<Qualifications>().AsEnumerable();
        using (var connection = _context.dbConnection())
        {
            result = await connection.QueryAsync<Qualifications>("SELECT * FROM Qualifications");
        }

        return result;
    }

    public async Task<Qualifications> GetQualificationByGuid(Guid qualificationId)
    {
        var result = new Qualifications();
        using (var connection = _context.dbConnection())
        {
            result = await connection.QueryFirstAsync<Qualifications>(
                $"SELECT * FROM Qualifications WHERE qualificationId = '{qualificationId}'");
        }

        return result;
    }

    public async Task<IEnumerable<Qualifications>> GetQualificationCoursesByGuid(Guid qualificationId)
    {
        var result = new List<Qualifications>().AsEnumerable();
        using (var connection = _context.dbConnection())
        {
            result = await connection.QueryAsync<Qualifications>($"SELECT * FROM Courses WHERE qualificationId = '{qualificationId}'");
        }

        return result;
    }
}
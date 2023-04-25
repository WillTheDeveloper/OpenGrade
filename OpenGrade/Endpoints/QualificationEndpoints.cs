using Microsoft.AspNetCore.Mvc;
using OpenGrade.Service;

namespace OpenGrade.Endpoints;

public static class QualificationEndpoints
{
    public static void MapQualificationEndpoints(this WebApplication app)
    {
        app.MapGet("/qualifications", async ([FromServices] IQualificationService service) =>
        {
            return Results.Ok(await service.GetAllQualifications());
        }).WithTags("Qualification");

        app.MapGet("/qualification/{qualificationId}", async ([FromServices] IQualificationService service, [FromRoute] Guid qualificationId) =>
        {
            return Results.Ok(await service.GetQualificationByGuid(qualificationId));
        }).WithTags("Qualification");

        app.MapGet("/qualification/{qualificationId}/courses", async ([FromServices] IQualificationService service, [FromRoute] Guid qualificationId) =>
        {
            return Results.Ok(await service.GetQualificationCoursesByGuid(qualificationId));
        }).WithTags("Qualification");
    }
}
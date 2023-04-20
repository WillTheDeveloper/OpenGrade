using Microsoft.AspNetCore.Mvc;
using OpenGrade.Models;
using OpenGrade.Service;

namespace OpenGrade.Endpoints;

public static class BtecEndpoints
{
    public static void MapBtecEndpoints(this WebApplication app)
    {
        /*app.MapGet("/btec/test", async (ICourseService service)
			=> await service.TestMethod());*/

        app.MapGet("/btec/course", async (ICourseService service, string? subjectName) =>
        {
            if (string.IsNullOrEmpty(subjectName))
            {
                return Results.Ok(await service.TestMethod());
            }
            return Results.Ok(await service.CourseBySubject(subjectName));
        });
    }
}

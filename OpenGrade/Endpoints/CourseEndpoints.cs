using OpenGrade.Service;
using Microsoft.AspNetCore.Mvc;

namespace OpenGrade.Endpoints;

public static class CourseEndpoints
{
    public static void MapCourseEndpoints(this WebApplication app)
    {
        app.MapGet("/courses", async ([FromServices]ICourseService service) =>
        {
            return Results.Ok(await service.GetAllCourses());
        }).WithTags("Course");
    }
}
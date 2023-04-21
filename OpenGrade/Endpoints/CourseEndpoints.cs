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

		app.MapGet("/courses/subject/{subjectName}", async ([FromServices] ICourseService service, [FromRoute] string subjectName) =>
		{
			return Results.Ok(await service.CourseBySubject(subjectName));
		}).WithTags("Course");

		app.MapGet("/course/{courseGuid}", async ([FromServices] ICourseService service, [FromRoute] Guid courseGuid) =>
		{
			return Results.Ok(await service.GetCourseByGuid(courseGuid));
		}).WithTags("Course");

		app.MapGet("/course/{courseId}/grades", async([FromServices]ICourseService service, [FromRoute]Guid courseId) =>
		{
			return Results.Ok(await service.GetCourseGradesByGuid(courseId));
		}).WithTags("Course");
	}
}
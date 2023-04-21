using Microsoft.AspNetCore.Mvc;
using OpenGrade.Service;

namespace OpenGrade.Endpoints
{
	public static class SubjectEndpoints
	{
		public static void MapSubjectEndpoints(this WebApplication app)
		{

			app.MapGet("/subjects", async ([FromServices]ISubjectService service) =>
			{
				return Results.Ok(await service.GetAllSubjects());
			}).WithTags("Subjects");

			app.MapGet("/subject/{subjectName}", async ([FromServices] ISubjectService service, [FromRoute]string subjectName) =>
			{
				return Results.Ok(await service.GetSubjectByName(subjectName));
			}).WithTags("Subjects");

			app.MapGet("/subject/{subjectId}", async([FromServices] ISubjectService service, [FromRoute] Guid subjectId) =>
			{
				return Results.Ok(await service.GetSubjectByGuid(subjectId));
			}).WithTags("Subjects");
		}
	}
}

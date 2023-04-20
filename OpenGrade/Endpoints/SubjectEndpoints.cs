﻿using Microsoft.AspNetCore.Mvc;
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

			
		}
	}
}

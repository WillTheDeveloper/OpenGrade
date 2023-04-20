using OpenGrade;
using OpenGrade.Data;
using OpenGrade.Endpoints;
using OpenGrade.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<Context>();

// Data layer
builder.Services.AddScoped<ICourseData, CourseData>();

// Service layer
builder.Services.AddScoped<ICourseService, CourseService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapBtecEndpoints();

app.UseHttpsRedirection();

app.Run();
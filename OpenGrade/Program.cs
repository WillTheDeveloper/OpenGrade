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
builder.Services.AddScoped<ISubjectData, SubjectData>();

// Service layer
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ISubjectService, SubjectService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapSubjectEndpoints();
app.MapCourseEndpoints();

app.MapBtecEndpoints();

app.UseHttpsRedirection();

app.Run();
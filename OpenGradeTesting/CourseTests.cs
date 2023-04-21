using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenGrade.Data;
using OpenGrade.Service;
using OpenGrade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenGradeTesting
{
	public class CourseTests
	{
		private IConfiguration _configuration;
		private ICourseService _courseService;
		private ICourseData _courseData;
		private Context _context;

		[SetUp]
		public void Setup()
		{
			var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
			_configuration = builder.Build();

			var services = new ServiceCollection();
			services.AddSingleton(_configuration);

			_context = new Context(_configuration);
			_courseData = new CourseData(_context);
			_courseService = new CourseService(_courseData);
		}

		[Category("CourseTests")]
		[Test]
		public async Task TestThatAllCoursesReturnData()
		{
			var result = await _courseService.GetAllCourses();
			Assert.That(result, Is.Not.Null);
		}

		[Category("CourseTests")]
		[Test]
		public async Task TestThereAreMoreThanZeroCourses()
		{
			var result = await _courseService.GetAllCourses();
			Assert.That(result.Count, Is.GreaterThan(0));
		}
	}
}

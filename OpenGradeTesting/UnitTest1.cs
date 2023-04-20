using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenGrade;
using OpenGrade.Data;
using OpenGrade.Service;

namespace OpenGradeTesting
{
	public class Tests
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

		[Test]
		public async Task TestThatTestMethodReturnsData()
		{
			var result = await _courseService.TestMethod();
			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public async Task TestThereAreMoreThanZeroCourses()
		{
			var result = await _courseService.TestMethod();
			Assert.That(result.Count, Is.GreaterThan(0));
		}
	}
}
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

namespace OpenGradeTesting
{
	public class SubjectTests
	{
		private IConfiguration _configuration;
		private ISubjectService _subjectService;
		private ISubjectData _subjectData;
		private Context _context;

		[SetUp]
		public void Setup()
		{
			var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
			_configuration = builder.Build();

			var services = new ServiceCollection();
			services.AddSingleton(_configuration);

			_context = new Context(_configuration);
			_subjectData = new SubjectData(_context);
			_subjectService = new SubjectService(_subjectData);
		}

		[Category("SubjectTests")]
		[Test]
		public async Task TestThatAllSubjectsReturnData()
		{
			var result = await _subjectService.GetAllSubjects();
			Assert.That(result, Is.Not.Null);
		}

		[Category("SubjectTests")]
		[Test]
		public async Task TestThereAreMoreThanZeroSubjects()
		{
			var result = await _subjectService.GetAllSubjects();
			Assert.That(result.Count, Is.GreaterThan(0));
		}
	}
}

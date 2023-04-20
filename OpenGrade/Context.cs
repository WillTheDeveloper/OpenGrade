using System.Data;
using System.Data.SqlClient;

namespace OpenGrade
{
	public class Context
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;

			_connectionString = _configuration.GetConnectionString("DefaultConnection");
		}

		public IDbConnection dbConnection()
		{
			return new SqlConnection(_connectionString);
		}
    }
}

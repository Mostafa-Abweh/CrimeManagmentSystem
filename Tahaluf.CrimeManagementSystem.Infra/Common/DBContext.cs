using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Tahaluf.CrimeManagementSystem.Core.Common;

namespace Tahaluf.CrimeManagementSystem.Infra.Common
{
   public class DBContext : IDBContext
    {
        private DbConnection _connection;
        private readonly IConfiguration configuration;
        public DBContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(configuration["ConnectionStrings:DBConnectionString"]);
                    _connection.Open();
                }
                else
                {
                    if (_connection.State != ConnectionState.Open)
                    {
                        _connection.Open();
                    }
                }
                return _connection;
            }
        }
    }
}

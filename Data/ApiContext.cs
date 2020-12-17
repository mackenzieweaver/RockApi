using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Npgsql;
using RockApi.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Models;
using Microsoft.Extensions.Configuration;

namespace RockApi.Data
{
    public class ApiContext : DbContext
    {
        // constructor
        private readonly IConfiguration _configuration;
        public ApiContext(DbContextOptions<ApiContext> options, IConfiguration configuration) 
            : base(options)
        {
            _configuration = configuration;
        }

        // api methods come from PgAdmin functions - this mehtod is called from controllers
        public string CallPostgresFunction(string funcName)
        {
            var connection = new NpgsqlConnection(DataHelper.GetConnectionString(_configuration));
            connection.Open();

            // build command to call PgAdmin function
            using var cmd = new NpgsqlCommand(funcName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            // execute query
            using var reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);

            // returns either serialized json or empty string
            connection.Close();
            return dataTable.Rows.Count > 0 ? JsonConvert.SerializeObject(dataTable) : string.Empty;
        }
    }
}

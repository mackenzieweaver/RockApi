using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using RockApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Utilities
{
    public static class DataHelper
    {
        public static string GetConnectionString(IConfiguration configuration)
        {
            // the default connection string will come from appsettings.json like usual
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            // It will be automatically overwritten if we are running on Heroku
            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
            return string.IsNullOrEmpty(databaseUrl) ? connectionString : BuildConnectionString(databaseUrl);
        }

        private static string BuildConnectionString(string databaseUrl)
        {
            // Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.
            var databaseUri = new Uri(databaseUrl);
            var userInfo = databaseUri.UserInfo.Split(':');

            //Provides a simple way to create and manage the contents of connection strings used by the NpgsqlConnection class.
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = databaseUri.Host,
                Port = databaseUri.Port,
                Username = userInfo[0],
                Password = userInfo[1],
                Database = databaseUri.LocalPath.TrimStart('/')
            };
            return builder.ToString();
        }

        public static async Task ManageData(IHost host)
        {
            try
            {
                //This technique is used to obtain references to services
                using var svcScope = host.Services.CreateScope();
                var svcProvider = svcScope.ServiceProvider;

                //The service will run your migrations
                var dbContextSvc = svcProvider.GetRequiredService<ApiContext>();
                await dbContextSvc.Database.MigrateAsync();

                var services = svcScope.ServiceProvider;
                var context = services.GetRequiredService<ApiContext>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception while running Manage Data => {ex}");
            }
        }
    }
}

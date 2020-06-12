using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NETCore_AzureSQL.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            // Add and configure AzureServiceTokenProvider to securely access the SQL Database
            var conn = (Microsoft.Data.SqlClient.SqlConnection)Database.GetDbConnection();
            conn.AccessToken = (new Microsoft.Azure.Services.AppAuthentication.AzureServiceTokenProvider())
                .GetAccessTokenAsync("https://database.windows.net/").Result;
        }

        public DbSet<Models.Customer> Customer { get; set; }
    }
}

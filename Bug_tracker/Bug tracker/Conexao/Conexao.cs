using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bug_tracker.Conexao
{
    public class Conexao : IDesignTimeDbContextFactory<DB>
    {
        public DB CreateDbContext(string[] args = null)
        {
            string connectionString = "server=localhost;database=bugtracker;uid=root;password=root";
            var options = new DbContextOptionsBuilder<DB>();
            options.UseMySql(connectionString: connectionString);
            return new DB(options.Options);
        }
    }
}

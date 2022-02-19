using Bug_tracker.Model;
using Microsoft.EntityFrameworkCore;
namespace Bug_tracker.Conexao
{
    public  class DB : DbContext
    {
        public DB(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=bugtracker;uid=root;password=root";
            optionsBuilder.UseMySql(connectionString: connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Bug> Bug { get; set; }
    }
}

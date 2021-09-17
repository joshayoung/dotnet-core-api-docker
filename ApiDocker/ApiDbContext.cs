using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApiDocker
{
    public class ApiDbContext : DbContext
    {
        private readonly IConfiguration config;

        public ApiDbContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            this.config = config;
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost,1432;Database=myCourses;User Id=sa;Password=myPass123;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
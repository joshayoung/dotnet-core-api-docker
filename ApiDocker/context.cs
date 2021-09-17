using Microsoft.EntityFrameworkCore;

namespace ApiDocker
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=myCourses;User Id=sa;Password=myPass123;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }

        public DbSet<ClassRoom> classRooms { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

        public  DemoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CEIJQT1;Database=StudyEntity;Trusted_Connection=True;");

        }
    }
}

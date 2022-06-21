using EmployeeOrganizationData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOrganizationData
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization> Organizations { get; set; } 
        public DemoDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CEIJQT1;Database=EmployeeOrganization;Trusted_Connection=True;");

        }
    }
}


using Microsoft.EntityFrameworkCore;
using OrderAssignmentEF.MasterAllData;

namespace OrderAssignmentEF
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Item> item { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DemoDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CEIJQT1;Initial Catalog=OrderDetails;Integrated Security=True");

        }
    }
}

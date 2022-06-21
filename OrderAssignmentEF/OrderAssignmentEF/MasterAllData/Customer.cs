using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderAssignmentEF.MasterAllData
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        [Key]
        public int ID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }


        public int Phone { get; set; }

        public string? Email { get; set; }

        public ICollection<Customer>? customer { get; set; }
    }
}

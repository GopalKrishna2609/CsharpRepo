using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOrganizationData.Entities
{
    public class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }
        public int YearsOfWork { get; set; }

        public Employee Employees { get; set; }
    }
}

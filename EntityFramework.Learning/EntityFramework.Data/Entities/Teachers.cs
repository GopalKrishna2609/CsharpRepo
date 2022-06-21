using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Data.Entities
{
    public class Teachers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }

        [Column(TypeName = "Varchar(50)")]

        public string? Name { get; set; }

        public ICollection<ClassRoom> classRooms { get; set; }
    }
}

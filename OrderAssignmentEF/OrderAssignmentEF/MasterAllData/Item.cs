using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderAssignmentEF.MasterAllData
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        [Key]
        public int ID { get; set; }

        public string? ItemName { get; set; }

        public int ItemRate { get; set; }
        public int ItemQTY { get; set; }
    }
}

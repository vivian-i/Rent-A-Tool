using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Maintenance
    {
        [Key]
        public string Id { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Description { get; set; }
        public string TechnicianName { get; set; }
        public double Cost { get; set; }

        [ForeignKey(nameof(Equipment))]
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}

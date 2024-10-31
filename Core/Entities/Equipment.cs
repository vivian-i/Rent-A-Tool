using Core.Entities.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    /**
     *  Equipment optional 1-to-1 Maintenance
     */
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public ConditionCategory Condition { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public double DailyRate {  get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey(nameof(Rental))]
        public int? RentalId { get; set; }
        public Rental? Rental { get; set; }

        public Maintenance? Maintenance { get; set; }
    }
}

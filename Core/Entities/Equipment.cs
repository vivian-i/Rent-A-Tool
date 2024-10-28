using Core.Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public ConditionCategory Condition { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public double DailyRate {  get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }
    }
}

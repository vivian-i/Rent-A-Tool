using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    /**
     * Rental optional 1-to-many Equipment
     * Rental required 1-to-many Invoices
     * 
     */
    public class Rental
    {
        [Key]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double TotalCost { get; set; }
        public bool IsReturned { get; set; }
        public DateTime ReturnDate { get; set; }
        public string? Note { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public ICollection<Equipment> Equipments { get; } = new List<Equipment>();
        public ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    }
}

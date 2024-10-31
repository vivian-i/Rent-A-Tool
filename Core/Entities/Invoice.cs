using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    /**
     *  Invoice one-to-one Rental
     * 
     */
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime InvoiceDate { get; set; }
        public double AmountDue { get; set; }
        public double AmountPaid {  get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMethod { get; set; }

        [ForeignKey(nameof(Rental))]
        public int RentalId { get; set; }
        public Rental Rental { get; set; }

        [ForeignKey(nameof(Equipment))]
        public int EquipmentId { get; set;}
        public Invoice Equipment {  get; set; }
    }
}

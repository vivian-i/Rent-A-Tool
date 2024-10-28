using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double AmountDue { get; set; }
        public double AmountPaid {  get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMethod { get; set; }

        [ForeignKey(nameof(Rental))]
        public int RentalId { get; set; }
        public Rental Rental { get; set; }
    }
}

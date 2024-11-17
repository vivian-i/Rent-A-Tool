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
        public int Id { get; set; }

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
        public Equipment Equipment {  get; set; }

        [ForeignKey(nameof(BatchInvoice))]
        public int BatchInvoiceId { get; set; }
        public BatchInvoice BatchInvoice {  get; set; }
    }
}

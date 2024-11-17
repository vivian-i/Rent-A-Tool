using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /**
     * A Batch contains 1 to many Invoices
     * BatchInvoice required 1-to-many Invoices
     */
    public class BatchInvoice
    {
        [Key]
        public int id { get; set; }

        [Required]
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        //in invoice set the fr id


    }
}

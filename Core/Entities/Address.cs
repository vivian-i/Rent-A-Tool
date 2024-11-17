using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    /**
     *  Client required 1-to-1 Address
     */
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}

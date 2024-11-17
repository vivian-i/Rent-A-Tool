using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    /**
     * Client optional 1-to-many Rentals
     * Client required 1-to-1 Address
     */
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        [ForeignKey(nameof(AppUser))]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public Address Address { get; set; }
        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}

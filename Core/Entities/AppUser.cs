using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    /**
     * public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
     */
    public class AppUser// : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        private string FirstName { get; set; }
        [NotMapped]
        private string LastName { get; set; }

        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }


        [ForeignKey(nameof(Client))]
        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}

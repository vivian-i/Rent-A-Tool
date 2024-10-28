using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class AppUser //: IdentityId
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        public int Role { get; set; } // admin / client role

        [ForeignKey(nameof(Admin))]
        public int? AdminId { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey(nameof(Client))]
        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}

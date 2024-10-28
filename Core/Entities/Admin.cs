using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey(nameof(AppUser))]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}

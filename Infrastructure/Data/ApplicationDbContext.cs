using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Rental> Rentals { get; set;}
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration, e.g., relationships
        }

    }
}

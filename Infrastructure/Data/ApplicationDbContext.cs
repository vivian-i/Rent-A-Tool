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
        public DbSet<BatchInvoice> BatchInvoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);//?
            // Additional configuration, e.g., relationships

            //Rental optional 1-to-many Equipments
            modelBuilder.Entity<Rental>()
                .HasMany(e => e.Equipments)
                .WithOne(e => e.Rental)
                .HasForeignKey(e => e.RentalId)
                .IsRequired(false);

            //Rental required 1-to-many Invoices
            modelBuilder.Entity<Rental>()
                .HasMany(e => e.Invoices)
                .WithOne(e => e.Rental)
                .HasForeignKey(e => e.RentalId)
                .OnDelete(DeleteBehavior.ClientCascade)
                .IsRequired(true);

            //Client optional 1-to-many Rentals
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Rentals)
                .WithOne(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .IsRequired(false);

            //Client required 1-to-1 Address
            modelBuilder.Entity<Client>()
                .HasOne(e => e.Address)
                .WithOne(e => e.Client)
                .HasForeignKey<Address>(e => e.ClientId)
                .OnDelete(DeleteBehavior.ClientCascade)
                .IsRequired(true);

            //Equipment optional 1-to-1 Maintenance


        }

    }
}

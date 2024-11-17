using Core.Entities;
using Core.Entities.Enum;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Data
{
    public class Seed
    {
        public static async Task SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                await context.Database.EnsureCreatedAsync();

                if (!await context.Equipments.AnyAsync())
                {
                    context.Equipments.AddRange(new List<Equipment>()
                    {
                        new Equipment()
                        {
                            Name = "Excavator",
                            Description = "Heavy Machinery XX Description of Excavator ",
                            SerialNumber = "N983298H8",
                            Condition = ConditionCategory.Good,
                            LastMaintenanceDate = DateTime.UtcNow,
                            DailyRate = 50.50,
                            IsAvailable = true,
                            ImageUrl = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        },
                        new Equipment()
                        {
                            Name = "Concrete Mixer",
                            Description = "Heavy Machinery XX Description of Concrete Mixer ",
                            SerialNumber = "Tx90880000",
                            Condition = ConditionCategory.Excellent,
                            LastMaintenanceDate = DateTime.UtcNow,
                            DailyRate = 70,
                            IsAvailable = false,
                            ImageUrl = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        },
                        new Equipment()
                        {
                            Name = "Chainsaw",
                            Description = "XX Description of Chainsaw",
                            SerialNumber = "98HKID802108J",
                            Condition = ConditionCategory.UnderMaintenance,
                            LastMaintenanceDate = new DateTime(2020, 09, 01),
                            DailyRate = 15,
                            IsAvailable = false,
                            ImageUrl = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        },
                        new Equipment()
                        {
                            Name = "Forklift",
                            Description = "XX Description of Forklift",
                            SerialNumber = "9283JO308J",
                            Condition = ConditionCategory.Excellent,
                            LastMaintenanceDate = DateTime.Now,
                            DailyRate = 100,
                            IsAvailable = true,
                            ImageUrl = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                        }
                    });
                    await context.SaveChangesAsync();
                }
                //Clients
                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(new List<Client>()
                    {
                        new Client()
                        {
                            Id = 1,
                            Name = "Hugo Smith",
                            PhoneNumber = "0478393000",
                            Address = new Address
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "VIC"
                            }
                        } 
                    });
                    await context.SaveChangesAsync();
                }
            }
        }

        /*public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "teddysmithdeveloper@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "teddysmithdev",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }*/
    }
}
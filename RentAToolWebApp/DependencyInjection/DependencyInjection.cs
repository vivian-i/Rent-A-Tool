using Core.Interfaces;
using Core.Repositories;
using RentAToolWebApp.Services;

namespace RentAToolWebApp.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IEquipmentRepository, EquipmentRepository>();

            //Register services
            services.AddScoped<ClientService>();
            services.AddScoped<AuthService>();
        }
    }
}

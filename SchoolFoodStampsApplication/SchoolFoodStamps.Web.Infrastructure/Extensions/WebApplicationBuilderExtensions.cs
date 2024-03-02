using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolFoodStamps.Data;
using System.Reflection;


namespace SchoolFoodStamps.Web.Infrastructure.Extensions
{
    public static class WebApplicationBuilderExtensions
    {

        /// <summary>
        /// This method registers all services with their interfaces from the given assembly.
        /// The assembly is taken from the type of random service interface or implementation provided.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);

            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provider");
            }

            Type[] types = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implementationTtype in types)
            {
                Type? interfaceType = implementationTtype
                    .GetInterface($"I{implementationTtype.Name}");


                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No interface is provided with name: {implementationTtype.Name}");
                }

                services.AddScoped(interfaceType, implementationTtype);
            }

            return services;
        }

        /// <summary>
        /// This method registers the DbContext with the connection string from the configuration.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            services.AddDbContext<SchoolFoodStampsDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        /// <summary>
        /// This method registers the default Identity with the given configuration.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = config.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                    options.Password.RequireDigit = config.GetValue<bool>("Identity:Password:RequireDigit");
                    options.Password.RequireLowercase = config.GetValue<bool>("Identity:Password:RequireLowercase");
                    options.Password.RequireNonAlphanumeric = config.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                    options.Password.RequireUppercase = config.GetValue<bool>("Identity:Password:RequireUppercase");
                    options.Password.RequiredLength = config.GetValue<int>("Identity:Password:RequiredLength");
                })
                .AddEntityFrameworkStores<SchoolFoodStampsDbContext>()
                .AddDefaultTokenProviders();
            
            return services;
        }
    }
}

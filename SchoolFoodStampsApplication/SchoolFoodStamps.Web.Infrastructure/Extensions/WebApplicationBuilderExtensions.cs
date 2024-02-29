using Microsoft.Extensions.DependencyInjection;
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
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
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
                    throw new InvalidOperationException($"No interface is providet with name: {implementationTtype.Name}");
                }

                services.AddScoped(interfaceType, implementationTtype);
            }
        }
    }
}

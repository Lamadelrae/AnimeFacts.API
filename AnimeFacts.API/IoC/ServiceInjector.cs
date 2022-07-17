using AnimeFacts.API.SharedKernel.Extensions;

namespace AnimeFacts.API.IoC;

public static class ServiceInjector
{
    public static void RegisterServicesByType<TBaseType>(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Transient)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes());
        var interfaces = types.Where(x => !x.IsClass && x.GetInterfaces().Contains(typeof(TBaseType)));

        foreach (var interfaceType in interfaces)
        {
            var implementation = types.FirstOrDefault(x => x.IsClass && !x.IsAbstract && typeof(TBaseType).In(x.GetInterfaces()) && interfaceType.In(x.GetInterfaces()));

            if (implementation != null)
            {
                services.Add(new ServiceDescriptor(interfaceType, implementation, lifetime));
            }
        }
    }
}

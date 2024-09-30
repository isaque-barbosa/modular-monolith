using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System;
using System.Linq;
using System.Reflection;

namespace Api.Configuration;

public static class ControllerConfiguration
{
    public static IServiceCollection AddModules(this IServiceCollection services)
    {
        AddControllersFromNamespace(services, "User.Module.Application");
        AddControllersFromNamespace(services, "Product.Module.Application");
        AddControllersFromNamespace(services, "Payment.Module.Application");

        return services;
    }

    private static void AddControllersFromNamespace(IServiceCollection services, string namespaceName)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(a => a.GetTypes().Any(t => t.Namespace == namespaceName))
            .ToList();

        foreach (var assembly in assemblies)
        {
            AddAssemblyPart(services, assembly);
        }
    }

    private static void AddAssemblyPart(IServiceCollection services, Assembly assembly)
    {
        services.AddControllers()
            .PartManager.ApplicationParts
            .Add(new AssemblyPart(assembly));
    }
}
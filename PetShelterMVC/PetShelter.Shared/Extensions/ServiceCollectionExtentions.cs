using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

public static class ServiceCollectionExtentions
{
	
	public static void AutoBund(this IServiceCollection source, params Assembly[] assmblies)
	{
		source.Scan(scan => scan.FromAssemblies(assmblies)
		.AddClasses(classes => classes.WithAttribute<AutoBindAttribute>())
		.AsImplementedInterfaces()
		.WithScopedLifetime());
		
    }
}
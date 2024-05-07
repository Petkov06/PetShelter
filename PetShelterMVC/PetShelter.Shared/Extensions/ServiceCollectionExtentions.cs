using Microsoft.Extensions.DependencyInjection;
using PetShelter.Shared.Attributes;
using System;
using System.Reflection;

namespace PetShelter.Shared.Extensions
{
	public static class ServiceCollectionExtentions
	{

		public static void AutoBind(this IServiceCollection source, params Assembly[] assmblies)
		{
			source.Scan(scan => scan.FromAssemblies(assmblies)
			.AddClasses(classes => classes.WithAttribute<AutoBindAttribute>())
			.AsImplementedInterfaces()
			.WithScopedLifetime());

		}
	}
}
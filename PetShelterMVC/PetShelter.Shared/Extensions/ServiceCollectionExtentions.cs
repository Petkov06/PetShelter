using System;

public static class ServiceCollectionExtentions
{
	public ServiceCollectionExtentions()
	{
	}

	public static void AutoBund(this IServiceCollection source, params Assmbly[] assmblies)
    {
		source.Scan(scan => scan.FromAssemblies(assmblies).AddClasses(classes => classes.WithAttribute<AutoBindAttribute>())
		.AsImplementedInterfaces()
		.WithScopedLifeTime());
		)
    }
}
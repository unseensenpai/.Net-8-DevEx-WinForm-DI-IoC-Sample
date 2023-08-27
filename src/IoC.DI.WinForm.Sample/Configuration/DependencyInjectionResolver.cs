
// Should Microsoft.Extensions.DependencyInjection for Program.cs usage.
namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionResolver
    {
        public static IServiceCollection AddServiceModules(this IServiceCollection services) =>
            services
                .AddEmployeeModule()

                ;
    }
}


// Should Microsoft.Extensions.DependencyInjection for Program.cs usage.
using IoC.DI.WinForm.Sample.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionResolver
    {
        public static IServiceCollection AddServiceModules(this IServiceCollection services) =>
            services
                .AddFormModule()
                .AddEmployeeModule()

                ;
    }
}

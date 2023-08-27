using IoC.DI.WinForm.Sample.Contracts;
using IoC.DI.WinForm.Sample.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EmployeeConfigurationExtensions
    {
        public static IServiceCollection AddEmployeeModule(this IServiceCollection services)
            => services
                .AddTransient<IEmployeeService, EmployeeService>()

            ;

    }
}

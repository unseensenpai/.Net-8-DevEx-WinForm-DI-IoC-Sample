using IoC.DI.WinForm.Sample.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.DI.WinForm.Sample.Configuration
{
    public static class FormRegisterExtensions
    {
        /// <summary>
        /// Register your forms for IServiceProvider
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddFormModule(this IServiceCollection services)
            => services
                .AddSingleton<Container>()
                .AddTransient<SubForm>()
            ;
    }
}

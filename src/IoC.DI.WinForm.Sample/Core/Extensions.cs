using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.WinForm.Sample.Extensions
{
    public static class Extensions
    {
        public static void AddLazyScoped<T>(this IServiceCollection services)
        {
            services.AddScoped<Lazy<T>>();
        }


    }
    
    public class Lazier<T> : Lazy<T> where T : class
    {
        public Lazier(IServiceProvider provider) : base(provider.GetRequiredService<T>)
        {

        }
    }

}

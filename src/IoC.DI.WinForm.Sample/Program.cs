using DevExpress.LookAndFeel;
using DevExpress.Skins;
using IoC.DI.WinForm.Sample.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting.Compact;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Windows.Forms;

namespace IoC.DI.WinForm.Sample
{
    internal static class Program
    {
        /// <summary>
        /// Single thread application WinForm limitations.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var sw = Stopwatch.StartNew();
            // Set Visual Settings
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableMdiFormSkins();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            // Set Logger Settings
            string fileFormatter = "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";
            string consoleFormatter = "{Timestamp:HH:mm} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}";
            Logger logConfig = new LoggerConfiguration()
                .WriteTo.File( restrictedToMinimumLevel: LogEventLevel.Warning, formatter: new CompactJsonFormatter(), path: "Logs\\Log.json", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true, fileSizeLimitBytes: 100000000) // 100 MB
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Information, outputTemplate: consoleFormatter)
                .WriteTo.Udp(restrictedToMinimumLevel: LogEventLevel.Information, remoteAddress: "127.0.0.1", remotePort: 7071, family: AddressFamily.InterNetwork, outputTemplate: consoleFormatter)
                .CreateLogger();
            Log.Logger = logConfig;

            // WinForm Dependency Injection and IoC            
            IHost host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    RegisterConfigs(builder);
                })
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(context.Configuration, services);
                })
                .ConfigureLogging((logging) =>
                {
                    ConfigureLogger(logging);
                })
                .Build();
            IServiceProvider services = host.Services;
            Container container = services.GetRequiredService<Container>();
            Application.Run(container);
            sw.Stop();
            var timerResult = Convert.ToDecimal(sw.ElapsedMilliseconds / 1000);
            Log.Information("WinForm DI Test Application Started!! Takes {timerResult} seconds to start!", timerResult);



            // What normally STA Thread apps do:
            //Application.Run(new Container());
        }

        private static void ConfigureLogger(Microsoft.Extensions.Logging.ILoggingBuilder logging)
        {
            logging.Services.AddSingleton<ILogger, Logger>();
        }

        private static void RegisterConfigs(IConfigurationBuilder builder)
        {
            builder.AddJsonFile("appsettings.json", true, true);
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            // Map Configs
            //services.Configure<TESTCONFIGOBJECT>(configuration.GetSection("User"));

            // Create HTTP clients for all app.
            //services.AddHttpClient(configuration.GetSection("ClientNames:HttpClientName").Value, options =>
            services.AddHttpClient("localhost", options =>
            {
                options.BaseAddress = new Uri("https://localhost:5000/api/"); //new Uri(configuration.GetSection("Endpoints:UyumserviceEP").Value);
                options.DefaultRequestHeaders.Accept.Clear();
                options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", configuration.GetSection("AuthSettings:Token").Value);
                options.Timeout = TimeSpan.FromMinutes(15);
            });

            // Register Forms and Services
            services.AddFormModule();
            services.AddServiceModules();
        }
    }
}

using KafkaTool.App;
using KafkaTool.Interfaces;
using KafkaTool.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;

namespace KafkaTool
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            var builder = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.SetBasePath(Directory.GetCurrentDirectory());
                    configApp.AddJsonFile(
                        $"Config/appsettings.json",
                        optional: true,
                        reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.Configure<AppSetting>(hostContext.Configuration);
                    services.AddTransient<IKafkaApp, KafkaApp>();
                    services.AddTransient<IKafkaConsumer, KafkaConsumer>();
                    services.AddSingleton<MainForm>();
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var mainForm = services.GetRequiredService<MainForm>();
                    Application.Run(mainForm);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Fails to start program: " + ex.Message);
                }
            }
        }
    }
}

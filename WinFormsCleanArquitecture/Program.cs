using ApplicationBusiness;
using Data;
using DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Views.Vistas;


namespace WinFormsCleanArquitecture
{
    internal static class Program
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


            var services = new ServiceCollection();
            ConfigureServices(services);
            var servicePrivider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormMain());
            var mainForm = servicePrivider.GetRequiredService<FormMain>();
            Application.Run(mainForm);

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .Build();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DB")));

            
            services.AddTransient<AddBrand>();
            services.AddTransient<EditBrand>();
            services.AddTransient<IRepository<BrandDto>, BrandRepository>();

            services.AddTransient<FormMain>();
            services.AddTransient<FormBrand>();
            services.AddTransient<AltaMarca>();
            
        }
    }
}
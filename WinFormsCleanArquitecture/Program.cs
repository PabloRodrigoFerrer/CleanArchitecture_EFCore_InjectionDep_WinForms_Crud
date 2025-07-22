using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using ApplicationBusiness.Mappers;
using Data;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.AdditionalDataClass;
using Repository.Mappers;
using Repository.QueryObjects;
using Views;
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
            services.AddTransient<AddBeer<BeerAdditionalData>>();
            services.AddTransient<EditBeer<BeerAdditionalData>>();
            services.AddTransient<GetBeerById<BeerAdditionalData>>();

            services.AddTransient<IRepository<Brand>, BrandRepository>();
            services.AddTransient<IRepositoryAdditionalData<Beer, BeerAdditionalData>, BeerRepository>();
            services.AddTransient<BeerWithBrandAndQuery>();

            services.AddTransient<IMapper<BeerDTO, Beer>, MapperToBeerEntity>();
            services.AddTransient<IMapper<BeerDTO, BeerAdditionalData>, MapperToBeerAdditionalData>();
            services.AddTransient<ISuperMapper<Beer, BeerAdditionalData, BeerDTO>, MapperToBeerDto>();


            services.AddTransient<FormMain>();
            services.AddTransient<FormBrand>();
            services.AddTransient<FormBeer>();
            services.AddTransient<AltaMarca>();
            services.AddTransient<FormNewEditBeer>();

        }
    }
}
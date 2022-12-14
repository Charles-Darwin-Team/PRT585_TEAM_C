using _3BusinessLogicLayer.Interfaces;
using _3BusinessLogicLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3BusinessLogicLayer.Ioc
{
    public static class Init
    {
        public static void InitializeDependencies(IServiceCollection services, IConfiguration configuration)
        {
                      
            // Services
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPhoneService, PhoneService>();
            services.AddScoped<ILaptopService, LaptopService>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<ISportService, SportService>();
            //services.AddScoped<ICategoryService, CategoryService>();

        }
    }
}

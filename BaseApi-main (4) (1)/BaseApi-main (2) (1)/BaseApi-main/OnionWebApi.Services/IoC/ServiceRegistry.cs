using Microsoft.Extensions.DependencyInjection;
using OnionWebApi.Services.Services;


namespace OnionWebApi.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddScoped<ILoanServices, LoanServices>();
            services.AddScoped<IPayServices, PayServices>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}

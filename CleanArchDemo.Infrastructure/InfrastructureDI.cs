using CleanArchDemo.Application.Interface;
using CleanArchDemo.Infrastructure.Data;
using CleanArchDemo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArchDemo.Infrastructure
{
    public static class InfrastructureDI
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            //  DbContext cho PostgreSQL
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            // Đăng ký Repository
            services.AddScoped<IRepository, UserRepository>();
            return services;
        }
    }
}

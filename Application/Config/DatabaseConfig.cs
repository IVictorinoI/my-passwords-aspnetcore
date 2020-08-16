using Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Config
{
    public static class DatabaseConfig
    {
        public static IServiceCollection ConnectOnDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<DataContext>(opt =>
                    opt.UseNpgsql(configuration.GetConnectionString("MyWebApiConnection")));

            return services;
        }
    }
}

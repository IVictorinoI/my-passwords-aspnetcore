using System.Security.Claims;
using Application.Login;
using Application.Passwords;
using Application.Passwords.Validators;
using Application.Users;
using Application.Users.Current;
using Application.Users.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Config
{
    public static class DependencyInjectorConfig
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {

            services.AddScoped<IAplicPassword, AplicPassword>();
            services.AddScoped<IAplicUser, AplicUser>();
            services.AddScoped<IAplicLogin, AplicLogin>();
            services.AddScoped<IUserValidator, UserValidator>();
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<IPasswordValidator, PasswordValidator>();

            return services;
        }
    }
}

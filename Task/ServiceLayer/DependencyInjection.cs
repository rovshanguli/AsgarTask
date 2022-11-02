using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
        
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IStudentDetailService, StudentDetailService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddHttpContextAccessor();

            return services;
        }
    }
}

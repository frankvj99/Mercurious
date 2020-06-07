using Mercurius.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mercurius.Application
{
    public static class ApplicationExtensions
    {
        public static void UseMercuriousApplication(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ProductService>();
        }
    }
}

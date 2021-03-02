using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BooksEverywhereDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BooksEverywhereConnectionString"));
            });

            return services;
        }
    }
}

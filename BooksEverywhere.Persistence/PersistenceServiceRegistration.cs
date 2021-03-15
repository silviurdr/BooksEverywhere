using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Persistence.Repositories;
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
                options.UseSqlServer(configuration.GetConnectionString("BooksEverywhereConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));
            services.AddScoped(typeof(ILibraryRepository), typeof(LibraryRepository));
            services.AddScoped(typeof(IBookLendRepository), typeof(BookLendRepository));

            return services;
        }
    }
}

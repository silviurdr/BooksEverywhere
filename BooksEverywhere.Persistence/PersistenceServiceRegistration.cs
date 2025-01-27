﻿using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
                options.UseSqlServer(configuration.GetConnectionString("BooksEverywhereConnectionString")).LogTo(Console.WriteLine, LogLevel.Information));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IAuthorRepository), typeof(AuthorRepository));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));
            services.AddScoped(typeof(ILibraryRepository), typeof(LibraryRepository));
            services.AddScoped(typeof(IBookLendRepository), typeof(BookLendRepository));
            services.AddScoped(typeof(ILibraryUserRepository), typeof(LibraryUserRepository));
            services.AddScoped(typeof(IStackRepository), typeof(StackRepository));
            services.AddScoped(typeof(ISubjectRepository), typeof(SubjectRepository));
            services.AddScoped(typeof(ISubsidiaryRepository), typeof(SubsidiaryRepository));

            return services;
        }
    }
}

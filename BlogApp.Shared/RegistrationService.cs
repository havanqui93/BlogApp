using BlogApp.Shared.Context;
using BlogApp.Shared.Entities;
using BlogApp.Shared.Repositories;
using BlogApp.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared
{
    public static class RegistrationService
    {
        public static void AddSharedService(this IServiceCollection service, string connectionString, string dbName)
        {
            service.AddSingleton(d => new BlogAppDbContext(connectionString, dbName));
            service.AddScoped<UserRepository>();
            service.AddScoped<FeedRepository>();
            service.AddScoped<PostRepository>();
            service.AddScoped<HttpService>();
        }
    }
}

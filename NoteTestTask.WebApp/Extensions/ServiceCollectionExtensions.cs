using Microsoft.EntityFrameworkCore;
using NoteTestTask.WebApp.Data;
using NoteTestTask.WebApp.Interfaces;
using NoteTestTask.WebApp.Repositories;
using NoteTestTask.WebApp.Services;

namespace NoteTestTask.WebApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddSingleton<NotesCountTriggerService>();

            var connStr = configuration.GetConnectionString("PostgresConnStr");

            services.AddDbContext<EfPostgresDbContext>(
                cfg => cfg.UseNpgsql(connStr));
            services.AddDbContextFactory<EfPostgresDbContext>(
                cfg => cfg.UseNpgsql(connStr), ServiceLifetime.Scoped);

            return services;
        }
    }
}

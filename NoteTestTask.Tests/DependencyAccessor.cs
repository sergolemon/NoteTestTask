using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NoteTestTask.WebApp.Data;
using NoteTestTask.WebApp.Interfaces;
using NoteTestTask.WebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTestTask.Tests
{
    internal static class DependencyAccessor
    {
        public static IServiceProvider CreateServiceProvider()
        {
            return new ServiceCollection()
                .AddDbContext<EfPostgresDbContext>(cfg => cfg.UseInMemoryDatabase("db"))
                .AddDbContextFactory<EfPostgresDbContext>(cfg => cfg.UseInMemoryDatabase("db"), ServiceLifetime.Transient)
                .AddTransient<INoteRepository, NoteRepository>()
                .BuildServiceProvider();
        }
    }
}

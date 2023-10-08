using Microsoft.EntityFrameworkCore;
using NoteTestTask.WebApp.Data.Entities;

namespace NoteTestTask.WebApp.Data
{
    public class EfPostgresDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public EfPostgresDbContext(DbContextOptions<EfPostgresDbContext> opts) : base(opts)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<Note>().HasData(InitDb.Notes);

            base.OnModelCreating(modelBuilder);
        }
    }
}

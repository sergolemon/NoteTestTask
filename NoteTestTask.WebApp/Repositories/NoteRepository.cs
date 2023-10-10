using Microsoft.EntityFrameworkCore;
using NoteTestTask.WebApp.Data;
using NoteTestTask.WebApp.Data.Entities;
using NoteTestTask.WebApp.Interfaces;

namespace NoteTestTask.WebApp.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly IDbContextFactory<EfPostgresDbContext> _dbContextFactory;

        public NoteRepository(IDbContextFactory<EfPostgresDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task DeleteNoteAsync(Note note, CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
            db.Notes.Remove(note);
            await db.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateNoteAsync(Note note, CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
            db.Notes.Add(note);
            await db.SaveChangesAsync(cancellationToken);
        }

        public async Task<Note?> GetNoteByIdOrNullAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
            return await db.Notes.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IList<Note>> GetNotesAsync(
            int page, 
            int itemsCount, 
            string? searchQuery = null, 
            CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
            IQueryable<Note> query = db.Notes;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                searchQuery = searchQuery.ToLower();
                query = query.Where(x => x.Title.ToLower().StartsWith(searchQuery));
            }

            return await query.OrderByDescending(x => x.CreatedDate)
                .Skip((page - 1) * itemsCount)
                .Take(itemsCount).ToListAsync(cancellationToken);
        }

        public async Task<int> GetNotesTotalCountAsync(CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
            return await db.Notes.CountAsync(cancellationToken);
        }

        public async Task UpdateNoteAsync(Note note, CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);
            db.Update(note).Property(x => x.CreatedDate).IsModified = false;
            await db.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> GetNotesCountBySearchAsync(string? searchQuery, CancellationToken cancellationToken = default)
        {
            using var db = await _dbContextFactory.CreateDbContextAsync();
            IQueryable<Note> query = db.Notes;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                searchQuery = searchQuery.ToLower();
                query = query.Where(x => x.Title.ToLower().StartsWith(searchQuery));
            }
            
            return await query.CountAsync(cancellationToken);
        }
    }
}

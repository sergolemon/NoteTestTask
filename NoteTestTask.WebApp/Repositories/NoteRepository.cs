using Microsoft.EntityFrameworkCore;
using NoteTestTask.WebApp.Data;
using NoteTestTask.WebApp.Data.Entities;
using NoteTestTask.WebApp.Interfaces;

namespace NoteTestTask.WebApp.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly EfPostgresDbContext _dbContext;

        public NoteRepository(EfPostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteNote(Note note)
        {
            _dbContext.Notes.Remove(note);
        }

        public async Task<Note?> GetNoteByIdOrNullAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Notes.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IList<Note>> GetNotesAsync(
            int page, 
            int itemsCount, 
            string? searchQuery = null, 
            CancellationToken cancellationToken = default)
        {
            IQueryable<Note> query = _dbContext.Notes;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                searchQuery = searchQuery.ToLower();
                query = query.Where(x => x.Title.ToLower().StartsWith(searchQuery));
            }

            return await query.Skip((page - 1) * itemsCount).Take(itemsCount).ToListAsync(cancellationToken);
        }

        public async Task<int> GetNotesTotalCountAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Notes.CountAsync(cancellationToken);
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public void UpdateNote(Note note)
        {
            _dbContext.Notes.Update(note);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

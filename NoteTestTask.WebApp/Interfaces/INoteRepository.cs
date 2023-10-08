
using NoteTestTask.WebApp.Data.Entities;
using NoteTestTask.WebApp.ViewModels;

namespace NoteTestTask.WebApp.Interfaces
{
    public interface INoteRepository : IDisposable
    {
        Task<IList<Note>> GetNotesAsync(
            int page,
            int itemsCount,
            string? searchQuery = null,
            CancellationToken cancellationToken = default);
        Task<Note?> GetNoteByIdOrNullAsync(Guid id, CancellationToken cancellationToken = default);
        Task<int> GetNotesTotalCountAsync(CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void DeleteNote(Note note);
        void UpdateNote(Note note);
    }
}

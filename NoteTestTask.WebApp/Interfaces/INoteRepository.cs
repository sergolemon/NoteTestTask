
using NoteTestTask.WebApp.Data.Entities;
using NoteTestTask.WebApp.ViewModels;

namespace NoteTestTask.WebApp.Interfaces
{
    public interface INoteRepository
    {
        Task<IList<Note>> GetNotesAsync(
            int page,
            int itemsCount,
            string? searchQuery = null,
            CancellationToken cancellationToken = default);
        Task<Note?> GetNoteByIdOrNullAsync(Guid id, CancellationToken cancellationToken = default);
        Task<int> GetNotesTotalCountAsync(CancellationToken cancellationToken = default);
        Task DeleteNoteAsync(Note note, CancellationToken cancellationToken = default);
        Task UpdateNoteAsync(Note note, CancellationToken cancellationToken = default);
        Task CreateNoteAsync(Note note, CancellationToken cancellationToken = default);
        Task<int> GetNotesCountBySearchAsync(string? searchQuery, CancellationToken cancellationToken = default);
    }
}

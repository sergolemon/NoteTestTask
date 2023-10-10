using Microsoft.Extensions.DependencyInjection;
using NoteTestTask.WebApp.Data.Entities;
using NoteTestTask.WebApp.Interfaces;

namespace NoteTestTask.Tests
{
    public class NoteRepositoryTest
    {
        [Fact]
        public async Task TestCreateNote()
        {
            var sp = DependencyAccessor.CreateServiceProvider();
            var noteRepository = sp.GetRequiredService<INoteRepository>();

            var newNote = new Note() { Title = "Title", Description = "Description" };

            await noteRepository.CreateNoteAsync(newNote);

            Assert.NotNull(await noteRepository.GetNoteByIdOrNullAsync(newNote.Id));
        }

        [Fact]
        public async Task TestDeleteNote()
        {
            var sp = DependencyAccessor.CreateServiceProvider();
            var noteRepository = sp.GetRequiredService<INoteRepository>();

            var delNote = (await noteRepository.GetNotesAsync(1, 1)).First();

            await noteRepository.DeleteNoteAsync(delNote);

            Assert.Null(await noteRepository.GetNoteByIdOrNullAsync(delNote.Id));
        }
    }
}
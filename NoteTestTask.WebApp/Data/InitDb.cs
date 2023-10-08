using NoteTestTask.WebApp.Data.Entities;

namespace NoteTestTask.WebApp.Data
{
    public static class InitDb
    {
        public static IEnumerable<Note> Notes { get; } = new List<Note>() 
        { 
            new Note 
            { 
                Id = Guid.NewGuid(), 
                Title = "Breakfast", 
                Description = "Breakfast at 10em", 
                CreatedDate = DateTime.Now 
            },
            new Note
            {
                Id = Guid.NewGuid(),
                Title = "Lunch",
                Description = "Lunch at 2pm",
                CreatedDate = DateTime.Now
            },
            new Note
            {
                Id = Guid.NewGuid(),
                Title = "Dinner",
                Description = "Dinner at 8pm",
                CreatedDate = DateTime.Now
            }
        };
    }
}

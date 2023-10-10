using NoteTestTask.WebApp.Data.Entities;

namespace NoteTestTask.WebApp.Data
{
    public static class InitDb
    {
        public static IEnumerable<Note> Notes { get; } = new List<Note>() 
        {
            new Note
            {
                Title = "Long text note",
                Description = "long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text long text",
            },
            new Note 
            { 
                Title = "Breakfast", 
                Description = "Breakfast at 10em", 
            },
            new Note
            {
                Title = "Lunch",
                Description = "Lunch at 2pm",
            },
            new Note
            {
                Title = "Dinner",
                Description = "Dinner at 8pm",
            }
        };
    }
}

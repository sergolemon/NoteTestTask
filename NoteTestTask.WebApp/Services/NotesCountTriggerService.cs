namespace NoteTestTask.WebApp.Services
{
    public class NotesCountTriggerService
    {
        public Action OnCountIncrement { get; set; }
        public Action OnCountDecrement { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace NoteTestTask.WebApp.ViewModels
{
    public class EditNoteVm
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}

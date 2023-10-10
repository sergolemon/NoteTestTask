using System.ComponentModel.DataAnnotations;

namespace NoteTestTask.WebApp.ViewModels
{
    public class CreateNoteVm
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}

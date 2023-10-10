using System.ComponentModel.DataAnnotations;

namespace NoteTestTask.WebApp.ViewModels
{
    public class EditNoteVm
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(90)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
    }
}

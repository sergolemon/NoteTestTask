using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteTestTask.WebApp.Data.Entities;

namespace NoteTestTask.WebApp.Data.Configuration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("note_id");
            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(90);
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(300);
            builder.Property(x => x.CreatedDate).HasColumnName("created_date");
            builder.Property(x => x.UpdatedDate).HasColumnName("updated_date");
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using VidzyExercise.Models;

namespace VidzyExercise.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.GenreId)
                .IsRequired();
        }
    }
}
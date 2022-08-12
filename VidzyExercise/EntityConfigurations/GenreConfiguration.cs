using System.Data.Entity.ModelConfiguration;
using VidzyExercise.Models;

namespace VidzyExercise.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
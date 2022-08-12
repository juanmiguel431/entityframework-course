using System.Data.Entity.ModelConfiguration;
using VidzyExercise.Models;

namespace VidzyExercise.EntityConfigurations
{
    public class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(t => t.Videos)
                .WithMany(v => v.Tags)
                .Map(c =>
                {
                    c.ToTable("VideoTags")
                        .MapLeftKey("TagId")
                        .MapRightKey("VideoId");
                });
        }
    }
}
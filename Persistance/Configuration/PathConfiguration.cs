using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class PathConfiguration : IEntityTypeConfiguration<Path>
    {
        public void Configure(EntityTypeBuilder<Path> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.CreateAppId)
                 .HasMaxLength(50);

            builder.Property(e => e.LastModifiedAppId)
                .HasMaxLength(50);

            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(e => e.IsHidden)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(e => e.Name)
                .IsRequired();

            builder.HasMany(d => d.Courses)
                .WithOne(d => d.Path)
                .HasForeignKey(d => d.PathId)
                .HasConstraintName("FK_Paths_Courses_PathId");
        }
    }
}

using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
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

                builder.Property(e => e.PathId)
                    .IsRequired();

                builder.HasMany(d => d.Groups)
                    .WithOne(d => d.Course)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Courses_Groups_CourseId");

                builder.HasMany(d => d.Subjects)
                    .WithOne(d => d.Course)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Courses_Subjects_CourseId");
        }
    }
}
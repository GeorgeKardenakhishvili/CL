using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
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

            builder.Property(e => e.StartDate)
                .IsRequired();

            builder.Property(e => e.EndDate)
                .IsRequired();

            builder.HasMany(d => d.SchedulePeople)
                .WithOne(d => d.Schedule)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK_Schedule_SchedulePeople_ScheduleId");
 
        }
    }
}

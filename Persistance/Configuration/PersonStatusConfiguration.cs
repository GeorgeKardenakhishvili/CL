using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class PersonStatusConfiguration : IEntityTypeConfiguration<PersonStatus>
    {
        public void Configure(EntityTypeBuilder<PersonStatus> builder)
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

            builder.HasMany(d => d.StatusPeople)
                .WithOne(d => d.PersonStatus)
                .HasForeignKey(d => d.PersonStatusId)
                .HasConstraintName("FK_PersonStatus_StatusPeople_PersonStatusId");

            builder.HasMany(d => d.GroupPeople)
               .WithOne(d => d.PersonStatus)
               .HasForeignKey(d => d.PersonStatusId)
               .HasConstraintName("FK_PersonStatuses_GroupPeople_PersonStatusId");

            builder.HasMany(d => d.SchedulePeople)
                .WithOne(d => d.PersonStatus)
                .HasForeignKey(d => d.PersonStatusId)
                .HasConstraintName("FK_PersonStatus_SchedulePeople_PersonStatusId");
        }
    }
}

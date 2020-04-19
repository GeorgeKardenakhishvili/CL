using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class PersonContactTypeConfiguration : IEntityTypeConfiguration<PersonContactType>
    {
        public void Configure(EntityTypeBuilder<PersonContactType> builder)
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

            builder.HasMany(d => d.PersonContacts)
                .WithOne(d => d.PersonContactType)
                .HasForeignKey(d => d.PersonContactTypetId)
                .HasConstraintName("FK_PersonContactTypes_PersonContacts_PersonContactTypeId");
        }
    }
}

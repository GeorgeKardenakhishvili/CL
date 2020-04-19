using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class PersonContactConfiguration  : IEntityTypeConfiguration<PersonContact>
    {
        public void Configure(EntityTypeBuilder<PersonContact> builder)
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

            builder.Property(e => e.PersonId)
                .IsRequired();

            builder.Property(e => e.PersonContactTypetId)
                .IsRequired();

            builder.Property(e => e.Contact)
                .IsRequired();
        }
    }
}

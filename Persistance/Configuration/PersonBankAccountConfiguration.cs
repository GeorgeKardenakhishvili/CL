using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class PersonBankAccountConfiguration : IEntityTypeConfiguration<PersonBankAccount>
    {
        public void Configure(EntityTypeBuilder<PersonBankAccount> builder)
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

            builder.Property(e => e.BankId)
                .IsRequired();

            builder.Property(e => e.AccountNumber)
                .IsRequired();
        }
    }
}

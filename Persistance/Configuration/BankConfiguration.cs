using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
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

            builder.HasMany(e => e.PersonBankAccounts)
                .WithOne(e => e.Bank)
                .HasForeignKey(e => e.BankId)
                .HasConstraintName("FK_Banks_PersonBankAccounts_BankId");
        }
    }
}

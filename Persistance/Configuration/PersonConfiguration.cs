using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
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

            builder.Property(e => e.FirstName)
                .IsRequired();

            builder.Property(e => e.FirstNameEn)
                .IsRequired();

            builder.Property(e => e.BirthDate)
                .IsRequired();

            builder.Property(e => e.PersonTypeId)
                .IsRequired();


            builder.HasMany(d => d.PersonContacts)
                .WithOne(d => d.Person)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_People_PersonContacts_PersonId");

            builder.HasMany(d => d.PersonAddresses)
                .WithOne(d => d.Person)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_People_PersonContacts_PathId");

            builder.HasMany(d => d.PersonBankAccounts)
                .WithOne(d => d.Person)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_People_PersonBankAccounts_PathId");

            builder.HasMany(d => d.PersonPersonStatuses)
                .WithOne(d => d.Person)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_People_PersonPersonStatuses_PathId");

            builder.HasMany(d => d.GroupPeople)
                .WithOne(d => d.Person)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_People_GroupPeople_PathId");

            builder.HasMany(d => d.SchedulePeople)
                .WithOne(d => d.Person)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_People_SchedulePeople_PathId");
        }
    }
}

using EClinic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EClinic.Repository.Configurations
{
    class AccountEntityTypeConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder
               .HasOne(a => a.Manager)
               .WithOne(b => b.Account)
               .HasForeignKey<User>(b => b.AccountId);
        }
    }
}
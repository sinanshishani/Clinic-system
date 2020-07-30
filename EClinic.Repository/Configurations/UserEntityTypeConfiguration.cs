using EClinic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EClinic.Repository.Configurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasOne(a => a.CreatorUser)
                .WithOne()
                .HasForeignKey<User>(a => a.CreatorUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.LastModifierUser)
                .WithOne()
                .HasForeignKey<User>(a => a.LastModifierUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.DeleterUser)
                .WithOne()
                .HasForeignKey<User>(a => a.DeleterUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
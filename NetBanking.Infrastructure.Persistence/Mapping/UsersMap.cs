using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Infrastructure.Persistence.Mapping
{
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users")
                .HasKey(u => u.Id);

            builder
                .HasMany<Products>(u => u.Products)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.IdUser)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany<Recipients>(u => u.Recipients)
                .WithOne(r => r.Recipient)
                .HasForeignKey(p => p.IdRecipient)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

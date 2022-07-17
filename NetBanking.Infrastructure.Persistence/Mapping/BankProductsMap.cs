using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Infrastructure.Persistence.Mapping
{
    public class BankProductsMap :IEntityTypeConfiguration<BankProducts>
    {
        public void Configure(EntityTypeBuilder<BankProducts> builder)
        {
            builder.ToTable("BankProducts")
                .HasKey(bp => bp.Id);


            builder
                .HasMany<Products>(bp => bp.Products)
                .WithOne(p => p.Produc)
                .HasForeignKey(p => p.IdProducType)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

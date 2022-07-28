using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Infrastructure.Persistence.Mapping
{
    public class ProductsMap : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products")
                .HasKey(p => p.Id);

            /*builder
                .HasMany<Transactions>(p => p.TransactionsOut)
                .WithOne(t => t.ProductFrom)
                .HasForeignKey(p => p.IdUserProduct)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany<Transactions>(p => p.TransactionsIn)
                .WithOne(t => t.ProducTo)
                .HasForeignKey(p => p.IdRecipientProduct)
                .OnDelete(DeleteBehavior.NoAction);*/
        }
    }
}

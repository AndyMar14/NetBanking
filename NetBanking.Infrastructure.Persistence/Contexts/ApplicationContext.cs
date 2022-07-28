using Microsoft.EntityFrameworkCore;
using NetBanking.Core.Domain.Entities;
using NetBanking.Infrastructure.Persistence.Mapping;

namespace NetBanking.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }
        public DbSet<BankProducts> BankProducts { get; set; }
        public DbSet<Recipients> Recipients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ProductsMap());
            builder.ApplyConfiguration(new BankProductsMap());
            builder.ApplyConfiguration(new RecipientsMap());
        }
    }
}

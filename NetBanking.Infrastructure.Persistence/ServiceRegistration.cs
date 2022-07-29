using Application.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Infrastructure.Persistence.Contexts;
using NetBanking.Infrastructure.Persistence.Repositories;

namespace NetBanking.Infrastructure.Persistence
{

    //Extension Method - Decorator
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
                {
                    options.EnableSensitiveDataLogging();
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));
                });
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<ITransactionsRepository, TransactionsRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IRecipientsRepository, RecipientsRepository>();
            services.AddTransient<IBankProductsRepository, BankProductsRepository>();
            #endregion
        }
    }
}

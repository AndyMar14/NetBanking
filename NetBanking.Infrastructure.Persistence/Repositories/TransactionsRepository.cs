using Application.Repository;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Domain.Entities;
using NetBanking.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Infrastructure.Persistence.Repositories
{
    public class TransactionsRepository : GenericRepository<Transactions>, ITransactionsRepository
    {
        private readonly ApplicationContext _dbContext;

        public TransactionsRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

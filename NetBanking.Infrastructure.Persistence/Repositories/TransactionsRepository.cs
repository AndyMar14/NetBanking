﻿using Application.Repository;
using Microsoft.EntityFrameworkCore;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.ViewModels.Transactions;
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

        public async Task<Transactions> Pay(SaveTransactionsViewModel vm)
        {
            Products accountFrom = await _dbContext.Set<Products>()
               .FirstOrDefaultAsync(a => a.Identifier == vm.UserProductId);

            Products accountTo = await _dbContext.Set<Products>()
                .FirstOrDefaultAsync(a => a.Identifier == vm.RecipientProductId);

            Transactions trans = new();

            if (accountFrom != null && accountTo != null)
            {

                accountFrom.Amount = (accountFrom.Amount - vm.Amount);
                var entryFrom = await _dbContext.Set<Products>().FindAsync(accountFrom.Id);
                _dbContext.Entry(entryFrom).CurrentValues.SetValues(accountFrom);
                await _dbContext.SaveChangesAsync();

                accountTo.Amount = (accountTo.Amount + vm.Amount);
                var entryTo = await _dbContext.Set<Products>().FindAsync(accountTo.Id);
                _dbContext.Entry(entryTo).CurrentValues.SetValues(accountTo);
                await _dbContext.SaveChangesAsync();

                trans.IdUserProduct = vm.UserProductId;
                trans.IdRecipientProduct = vm.RecipientProductId;
                trans.Fecha = DateTime.Now;
                trans.Type = 1;
                trans.Amount = vm.Amount;
                await _dbContext.Set<Transactions>().AddAsync(trans);
                await _dbContext.SaveChangesAsync();
            }

            return trans;
        }
    }
}

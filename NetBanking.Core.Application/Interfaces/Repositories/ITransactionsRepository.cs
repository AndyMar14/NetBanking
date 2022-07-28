﻿using NetBanking.Core.Application.ViewModels.Transactions;
using NetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Interfaces.Repositories
{
    public interface ITransactionsRepository : IGenericRepository<Transactions>
    {
        Task<TransactionsViewModel> Pay(SaveTransactionsViewModel vm);
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Transactions;
using NetBanking.Core.Domain.Entities;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Services
{
    public class TransactionsService : GenericService<SaveTransactionsViewModel, TransactionsViewModel, Transactions>, ITransactionsService
    {
        private readonly ITransactionsRepository _transactionsRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public TransactionsService(ITransactionsRepository transactionsRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper) : base(transactionsRepository, mapper)
        {
            _transactionsRepository = transactionsRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<TransactionsViewModel> Pay(SaveTransactionsViewModel vm)
        {
            TransactionsViewModel transaction = await _transactionsRepository.Pay(vm);

            return transaction;
        }
    }
}

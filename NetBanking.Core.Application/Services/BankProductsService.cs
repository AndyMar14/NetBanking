using AutoMapper;
using Microsoft.AspNetCore.Http;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.BankProducts;
using NetBanking.Core.Application.ViewModels.Transactions;
using NetBanking.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Services
{
    public class BankProductsService : GenericService<SaveBankProductsViewModel, BankProductsViewModel, BankProducts>, IBankProductsServices
    {
        private readonly IBankProductsRepository _bankProductsRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public BankProductsService(IBankProductsRepository bankProductsRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper) : base(bankProductsRepository, mapper)
        {
            _bankProductsRepository = bankProductsRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }
    }
}

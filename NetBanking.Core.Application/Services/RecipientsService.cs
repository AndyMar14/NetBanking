using AutoMapper;
using Microsoft.AspNetCore.Http;
using NetBanking.Core.Application.Helpers;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Recipients;
using NetBanking.Core.Application.ViewModels.Users;
using NetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Services
{
    public class RecipientsService : GenericService<SaveRecipientsViewModel, RecipientsViewModel, Recipients>, IRecipientsService
    {
        private readonly IAccountService _accountService;
        private readonly IRecipientsRepository _recipientsRepository;
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UsersViewModel usersViewModel;
        public RecipientsService(IAccountService accountService,IProductsRepository productsRepository,IRecipientsRepository recipientsRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(recipientsRepository, mapper)
        {
            _accountService = accountService;
            _recipientsRepository = recipientsRepository;
            _productsRepository = productsRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            usersViewModel = _httpContextAccessor.HttpContext.Session.Get<UsersViewModel>("user");
        }
        public async Task<List<RecipientsViewModel>> GetRecipients(string id)
        {
            //var lista = await _recipientsRepository.GetRecipients(id);
            var lista = await _recipientsRepository.GetAllAsync();

            var listVm = lista.Where(r => r.IdUser == id).Select(reci=> new RecipientsViewModel { 
                IdUser = reci.IdUser,
                IdRecipient = reci.IdRecipient
            } ).ToList();

            foreach (var p in listVm)
            {
                var product = await _productsRepository.GetProductByIdentifier(p.IdRecipient);
                p.Recipient = await _accountService.GetUserByIdAsync(product.IdUser);
            }
            return listVm;
        }

        public override async Task<SaveRecipientsViewModel> Add(SaveRecipientsViewModel vm)
        {
            var recipient = await _recipientsRepository.GetRecipientsId(vm.IdRecipient, usersViewModel.Id);

            if (recipient == null)
            {
                await base.Add(vm);
            }
            return vm;
        }
        public async Task DeleteRecipient(string Id)
        {
            var recipient = await _recipientsRepository.GetRecipientsId(Id, usersViewModel.Id);

            if (recipient != null)
            {
                await _recipientsRepository.DeleteAsync(recipient);
            }
        }
    }
}

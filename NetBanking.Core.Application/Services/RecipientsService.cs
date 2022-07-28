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
        private readonly IRecipientsRepository _recipientsRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UsersViewModel usersViewModel;
        public RecipientsService(IRecipientsRepository recipientsRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(recipientsRepository, mapper)
        {
            _recipientsRepository = recipientsRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            usersViewModel = _httpContextAccessor.HttpContext.Session.Get<UsersViewModel>("user");
        }
    }
}

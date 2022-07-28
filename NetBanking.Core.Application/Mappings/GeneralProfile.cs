using AutoMapper;
using NetBanking.Core.Application.Dtos.Account;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Application.ViewModels.Recipients;
using NetBanking.Core.Application.ViewModels.Users;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<AuthenticationRequest, LoginUsersViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<RegisterRequest, SaveUsersViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<Products, ProductsViewModel>()
                .ReverseMap();

            CreateMap<Recipients, SaveRecipientsViewModel>()
                .ReverseMap();

            CreateMap<Recipients, RecipientsViewModel>()
                .ReverseMap();

            CreateMap<Products, SaveProductsViewModel>()
                .ReverseMap()
                .ForMember(x => x.Produc, opt => opt.Ignore())
                .ForMember(x => x.TransactionsOut, opt => opt.Ignore())
                .ForMember(x => x.TransactionsIn, opt => opt.Ignore());

            /*CreateMap<ForgotPasswordRequest, ForgotPasswordViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ResetPasswordRequest, ResetPasswordViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();*/
        }
    }
}

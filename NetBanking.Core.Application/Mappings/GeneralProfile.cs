using AutoMapper;
using NetBanking.Core.Application.Dtos.Account;
using NetBanking.Core.Application.ViewModels.Products;
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

            //CreateMap<Products, ProductsViewModel>()
            //    .ForMember(x => x.ProductTypeId, opt => opt.Ignore())
            //    .ForMember(x => x.ProductIdentifier, opt => opt.Ignore())
            //    .ReverseMap()
            //    .ForMember(x => x.IdProducType, opt => opt.Ignore());


            //CreateMap<Products, SaveProductsViewModel>()
            //    .ForMember(x => x.File, opt => opt.Ignore())
            //    .ReverseMap()
            //    .ForMember(x => x.Created, opt => opt.Ignore())
            //    .ForMember(x => x.CreatedBy, opt => opt.Ignore())
            //    .ForMember(x => x.LastModified, opt => opt.Ignore())
            //    .ForMember(x => x.LastModified, opt => opt.Ignore())
            //    .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
            //    .ForMember(x => x.Category, opt => opt.Ignore());

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

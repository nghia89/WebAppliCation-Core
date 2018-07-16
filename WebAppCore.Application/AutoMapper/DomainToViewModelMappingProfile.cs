using AutoMapper;
using WebAppCore.Application.ViewModels.Product;
using WebAppCore.Application.ViewModels.System;
using WebAppCore.Data.Entities;

namespace WebAppCore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
            //CreateMap<Bill, BillViewModel>();
            //CreateMap<BillDetail, BillDetailViewModel>();
            //CreateMap<Color, ColorViewModel>();
            //CreateMap<Size, SizeViewModel>();
            //CreateMap<ProductQuantity, ProductQuantityViewModel>().MaxDepth(2);
            //CreateMap<ProductImage, ProductImageViewModel>().MaxDepth(2);
            //CreateMap<WholePrice, WholePriceViewModel>().MaxDepth(2);

            //CreateMap<Blog, BlogViewModel>().MaxDepth(2);
            //CreateMap<BlogTag, BlogTagViewModel>().MaxDepth(2);
            //CreateMap<Slide, SlideViewModel>().MaxDepth(2);
            //CreateMap<SystemConfig, SystemConfigViewModel>().MaxDepth(2);
            //CreateMap<Footer, FooterViewModel>().MaxDepth(2);
        }
    }
}
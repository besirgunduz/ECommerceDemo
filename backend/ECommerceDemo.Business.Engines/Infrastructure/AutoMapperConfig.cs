using AutoMapper;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Core.Entities;
using ECommerceDemo.Data.Entities;

namespace ECommerceDemo.Business.Engines.Infrastructure
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailModel>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}

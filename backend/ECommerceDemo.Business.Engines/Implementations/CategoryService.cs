using AutoMapper;
using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Data.Entities;

namespace ECommerceDemo.Business.Engines.Implementations
{
    public class CategoryService : BaseService<CategoryModel, Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}

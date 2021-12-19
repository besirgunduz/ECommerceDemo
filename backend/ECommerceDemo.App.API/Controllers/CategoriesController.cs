using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.App.API.Controllers
{
    public class CategoriesController : BaseController<CategoryModel, Category>
    {
        public CategoriesController(ICategoryService categoryService) : base(categoryService)
        {

        }

    }
}

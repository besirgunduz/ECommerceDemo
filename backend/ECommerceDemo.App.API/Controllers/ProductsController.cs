using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Business.Engines.Models.RequestModels;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Core.Utilities.Results;
using ECommerceDemo.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerceDemo.App.API.Controllers
{
    public class ProductsController : BaseController<ProductModel, Product>
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService) : base(productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProductListByCategoryId")]
        public IActionResult GetProductListByCategoryId(int categoryId)
        {
            var result = _productService.GetProductListByCategoryId(categoryId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("GetProductList")]
        public IActionResult GetProductList(ProductListRequestModel productListRequestModel)
        {
            var result = _productService.GetProductList(productListRequestModel);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

    }
}

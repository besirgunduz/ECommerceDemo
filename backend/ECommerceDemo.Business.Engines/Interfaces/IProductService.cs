using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Business.Engines.Models.RequestModels;
using ECommerceDemo.Core.Utilities.Results;
using ECommerceDemo.Data.Entities;
using System.Collections.Generic;

namespace ECommerceDemo.Business.Engines.Interfaces
{
    public interface IProductService : IEngineBase, IBaseService<ProductModel, Product>
    {
        IDataResult<List<ProductModel>> GetProductListByCategoryId(int categoryId);
        IDataResult<List<ProductModel>> GetProductList(ProductListRequestModel model);
    }
}

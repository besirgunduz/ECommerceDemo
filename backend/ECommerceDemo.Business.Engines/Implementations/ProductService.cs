using AutoMapper;
using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Business.Engines.Models.RequestModels;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Core.Utilities.Results;
using ECommerceDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceDemo.Business.Engines.Implementations
{
    public class ProductService : BaseService<ProductModel, Product>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IDataResult<List<ProductModel>> GetProductListByCategoryId(int categoryId)
        {
            try
            {
                var productRepository = _unitOfWork.GetRepository<Product>();
                var products = productRepository.Get(p => p.CategoryId == categoryId).
                    Select(product => _mapper.Map<ProductModel>(product)).ToList();
                return new SuccessDataResult<List<ProductModel>>(products, "listed");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<ProductModel>>($"Error:{ex.Message}");
            }
        }

        public IDataResult<List<ProductModel>> GetProductList(ProductListRequestModel model)
        {
            try
            {
                var allProducts = _unitOfWork.GetRepository<Product>().Get();
                if (model.CategoryId > 0)
                {
                    allProducts = allProducts.Where(p => p.CategoryId == model.CategoryId);
                }
                if (model.OrderBy != null)
                {
                    switch (model.OrderBy)
                    {
                        case OrderBy.PriceAsc:
                            allProducts = allProducts.OrderBy(p => p.Price);
                            break;
                        case OrderBy.PriceDesc:
                            allProducts = allProducts.OrderByDescending(p => p.Price);
                            break;
                    }
                }
                if (model.PageIndex < 1)
                {
                    model.PageIndex = 1;
                }
                if (model.PageSize < 1)
                {
                    model.PageSize = 10;
                }
                var products = allProducts.Skip((model.PageIndex - 1) * model.PageSize).Take(model.PageSize).ToList();
                var productModels = products.Select(p => _mapper.Map<ProductModel>(p)).ToList();
                return new SuccessDataResult<List<ProductModel>>(productModels, "listed");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<ProductModel>>($"Error:{ex.Message}");
            }
        }
    }
}

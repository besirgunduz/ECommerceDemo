using AutoMapper;
using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Data.Entities;

namespace ECommerceDemo.Business.Engines.Implementations
{
    public class OrderService : BaseService<OrderModel, Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}

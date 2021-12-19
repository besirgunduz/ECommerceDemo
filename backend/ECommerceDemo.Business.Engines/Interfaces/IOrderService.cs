using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Data.Entities;

namespace ECommerceDemo.Business.Engines.Interfaces
{
    public interface IOrderService : IEngineBase, IBaseService<OrderModel, Order>
    {
    }
}

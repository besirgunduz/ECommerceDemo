using ECommerceDemo.Core.Entities;
using ECommerceDemo.Core.Repository;
using System;

namespace ECommerceDemo.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}

using ECommerceDemo.Data.Entities;
using System.Collections.Generic;

namespace ECommerceDemo.Business.Engines.Interfaces
{
    public interface IUserService : IEngineBase
    {
        List<Role> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}

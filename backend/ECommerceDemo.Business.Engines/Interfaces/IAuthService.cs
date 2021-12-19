using ECommerceDemo.Business.Engines.Models;
using ECommerceDemo.Core.Utilities.Results;
using ECommerceDemo.Data.DAL.Security.JWT;
using ECommerceDemo.Data.Entities;

namespace ECommerceDemo.Business.Engines.Interfaces
{
    public interface IAuthService : IEngineBase
    {
        IDataResult<User> Register(UserForRegisterModel userForRegisterModel, string password);
        IDataResult<User> Login(UserForLoginModel userForLoginModel);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

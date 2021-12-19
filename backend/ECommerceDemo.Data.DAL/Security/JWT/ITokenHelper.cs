using ECommerceDemo.Data.Entities;
using System.Collections.Generic;

namespace ECommerceDemo.Data.DAL.Security.JWT
{
    // ilgili user için claimleri içerecek bir token üretecek
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<Role> operationClaims);
    }
}

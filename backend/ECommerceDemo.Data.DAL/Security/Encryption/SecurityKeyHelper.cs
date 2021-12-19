using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ECommerceDemo.Data.DAL.Security.Encryption
{
    //appsettings.json daki SecurityKey'imizi  oluşturur.
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}

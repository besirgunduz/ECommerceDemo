using Microsoft.IdentityModel.Tokens;

namespace ECommerceDemo.Data.DAL.Security.Encryption
{
    // hangi securityKey ve hangi algoritmayı kullanacağımızı belirttiğimiz yer yani imzamız :)
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}

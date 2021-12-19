using System;

namespace ECommerceDemo.Data.DAL.Security.JWT
{
    //oluşturulan token ve bitiş tarihi
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}

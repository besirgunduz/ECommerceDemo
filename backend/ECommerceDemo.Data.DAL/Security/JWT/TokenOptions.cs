namespace ECommerceDemo.Data.DAL.Security.JWT
{
    //appsettings.json dosyasındaki verileri atadığımız class
    public class TokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}

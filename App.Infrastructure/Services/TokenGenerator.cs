

using App.Application.Interfaces;

namespace App.Infrastructure.Services
{
    public class TokenGenerator : ITokenGenerator
    {
        private readonly string _key;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly string _expiryMinutes;

        public TokenGenerator(string key, string issuer, string audience, string expiryMinutes)
        {
            _key = key;
            _issuer = issuer;
            _audience = audience;
            _expiryMinutes = expiryMinutes;
        }
        public string GenerateJWTToken((string userId, string userName, string FName, string LName, string email, string img, IList<string> roles) userDetails)
        {
            throw new NotImplementedException();
        }
    }
}

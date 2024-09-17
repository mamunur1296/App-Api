namespace App.Application.Interfaces
{
    public interface ITokenGenerator
    {
        public string GenerateJWTToken((string userId, string userName, string FName, string LName, string email, string img, IList<string> roles) userDetails);
    }
}

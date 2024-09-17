using App.Application.DTOs;
using App.Application.Interfaces;

namespace App.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public Task<(bool Success, string ErrorMessage)> ChangePassword(string OldPassword, string newPassword, string Userid)
        {
            throw new NotImplementedException();
        }

        public Task<(bool isSucceed, string userId)> CreateUserAsync(RegistrationDTOs model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserDetailsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<(string userId, string FirstName, string LastName, string UserName, string email, IList<string> roles)> GetUserDetailsByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUniqueUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SigninUserAsync(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserProfile(UserDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

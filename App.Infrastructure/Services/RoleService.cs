using App.Application.Interfaces;

namespace App.Infrastructure.Services
{
    public class RoleService : IRoleService
    {
        public Task<bool> CreateRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<(string id, string roleName)> GetRoleByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<(string id, string roleName)>> GetRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRole(string id, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using RmDesktopUI.Library.Model;

namespace RmDesktopUI.Library.API
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAllUsers();

        Task<Dictionary<string, string>> GetAllRoles();

        Task AddUserToRole(string userId, string roleName);

        Task RemoveUserToRole(string userId, string roleName);
    }
}
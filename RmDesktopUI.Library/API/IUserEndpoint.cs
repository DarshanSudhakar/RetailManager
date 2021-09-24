using System.Collections.Generic;
using System.Threading.Tasks;
using RmDesktopUI.Library.Model;

namespace RmDesktopUI.Library.API
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAllUsers();
    }
}
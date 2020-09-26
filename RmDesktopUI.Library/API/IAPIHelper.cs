using RmDesktopUI.Library.Model;
using System.Threading.Tasks;

namespace RmDesktopUI.Library.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}
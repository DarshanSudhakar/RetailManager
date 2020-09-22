using System.Threading.Tasks;
using RmWPFUserInterface.Models;

namespace RmWPFUserInterface.Helper
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}
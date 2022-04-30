using RmDataManager.Library.Models;

namespace RmDataManager.Library.DataAccess
{
    public interface IUserData
    {
        UserModel GetUserById(string id);
    }
}
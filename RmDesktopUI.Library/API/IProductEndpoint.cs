using System.Collections.Generic;
using System.Threading.Tasks;
using RmDesktopUI.Library.Model;

namespace RmDesktopUI.Library.API
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}
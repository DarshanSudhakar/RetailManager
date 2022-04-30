using System.Threading.Tasks;
using RmDesktopUI.Library.Model;

namespace RmDesktopUI.Library.API
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}
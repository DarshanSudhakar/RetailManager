using RmDataManager.Library.Models;
using System.Collections.Generic;

namespace RmDataManager.Library.DataAccess
{
    public interface IProductData
    {
        ProductModel GetProductById(int productId);
        List<ProductModel> GetProducts();
    }
}
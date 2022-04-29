using Microsoft.Extensions.Configuration;
using RmDataManager.Library.Internal.DataAccess;
using RmDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmDataManager.Library.DataAccess
{
    public class ProductData : IProductData
    {
        private readonly ISqlDataAccess _sql;

        public ProductData(ISqlDataAccess sqlDataAccess)
        {
            _sql = sqlDataAccess;
        }

        public List<ProductModel> GetProducts()
        {
            var output = _sql.LoadData<ProductModel, dynamic>("RmData.dbo.spProduct_GetAll", new { }, "RmData");

            return output;
        }

        public ProductModel GetProductById(int productId)
        {
            var output = _sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetById", new { Id = productId }, "RmData").FirstOrDefault();

            return output;
        }
    }
}

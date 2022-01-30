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
    public class SaleData
    {
        private readonly IConfiguration _config;

        public SaleData(IConfiguration config)
        {
            _config = config;
        }
        public void SaveSale(SaleModel saleInfo, string cashierId)
        {
            //TODO: Make this SOLID/DRY/Better

            //Start filling in the sale detail models we will save to the database
            List<SaleDetailDBModel> details = new List<SaleDetailDBModel>();
            ProductData productData = new ProductData(_config);
            var taxRate = ConfigHelper.GetTaxRate();

            foreach (var item in saleInfo.SaleDetails)
            {
                var detail = new SaleDetailDBModel
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                //Fill in the available information
                //Get the information about this product
                var productInfo = productData.GetProductById(item.ProductId);

                if (productInfo == null)
                {
                    throw new Exception($"The product ID of {detail.ProductId} could not be found in the database");
                }

                detail.PurchasePrice = productInfo.RetailPrice * detail.Quantity;
                detail.Tax = productInfo.IsTaxable ? (detail.PurchasePrice * (taxRate / 100)) : 0;

                details.Add(detail);
            }

            //Create the Salemodel
            SaleDBModel sale = new SaleDBModel
            {
                SubTotal = details.Sum(x => x.PurchasePrice),
                Tax = details.Sum(x => x.Tax),
                CashierId = cashierId
            };

            sale.Total = sale.SubTotal + sale.Tax;

            
            using (SqlDataAccess sql = new SqlDataAccess(_config))
            {
                try
                {
                    sql.StartTransaction("RmData");

                    //Save the sale model
                    sql.SaveDataInTransaction<SaleDBModel>("dbo.spSale_Insert", sale);

                    //Get the ID from the sale model
                    sale.Id = sql.LoadDataInTransaction<int, dynamic>("dbo.spSale_Lookup", new { CashierId = sale.CashierId, SaleDate = sale.SaleDate }).FirstOrDefault();

                    //Finish filling in the sale detail models
                    foreach (var item in details)
                    {
                        item.SaleId = sale.Id;

                        //Save the sale detail models
                        sql.SaveDataInTransaction("dbo.spSaleDetails_Insert", item);
                    }

                    sql.CommitTransaction();
                }
                catch
                {
                    sql.RollbackTransaction();
                    throw;
                }
            }
        }

        public List<SaleReportModel> GetSaleReport()
        {
            SqlDataAccess sql = new SqlDataAccess(_config);

            var output = sql.LoadData<SaleReportModel, dynamic>("dbo.spSale_SaleReport", new { }, "RmData");

            return output;
        }
    }
}

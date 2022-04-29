﻿using RmDataManager.Library.Models;
using System.Collections.Generic;

namespace RmDataManager.Library.DataAccess
{
    public interface ISaleData
    {
        List<SaleReportModel> GetSaleReport();
        void SaveSale(SaleModel saleInfo, string cashierId);
    }
}
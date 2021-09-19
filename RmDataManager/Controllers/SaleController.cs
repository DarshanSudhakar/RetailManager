using Microsoft.AspNet.Identity;
using RmDataManager.Library.DataAccess;
using RmDataManager.Library.Models;
using RmDataManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RmDataManager.Controllers
{
    [Authorize]
    public class SaleController : ApiController
    {
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData();
            var cashierId = RequestContext.Principal.Identity.GetUserId();
            data.SaveSale(sale, cashierId);
        }

    }
}

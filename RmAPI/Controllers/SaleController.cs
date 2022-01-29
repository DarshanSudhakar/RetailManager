using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RmDataManager.Library.DataAccess;
using RmDataManager.Library.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace RmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SaleController : ControllerBase
    {
        [Authorize(Roles = "Cashier")]
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData();
            var cashierId = User.FindFirstValue(ClaimTypes.NameIdentifier); //Old way - RequestContext.Principal.Identity.GetUserId();
            data.SaveSale(sale, cashierId);
        }

        [Authorize(Roles = "Admin,Manager")]
        [Route("GetSalesReport")]
        public List<SaleReportModel> GetSalesReport()
        {
            SaleData data = new SaleData();

            return data.GetSaleReport();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly ISaleData _saleData;

        public SaleController(ISaleData saleData)
        {
            _saleData = saleData;
        }

        [Authorize(Roles = "Cashier")]
        [HttpPost]
        public void Post(SaleModel sale)
        {
            var cashierId = User.FindFirstValue(ClaimTypes.NameIdentifier); //Old way - RequestContext.Principal.Identity.GetUserId();
            _saleData.SaveSale(sale, cashierId);
        }

        [Authorize(Roles = "Admin,Manager")]
        [Route("GetSalesReport")]
        [HttpGet]
        public List<SaleReportModel> GetSalesReport()
        {
            return _saleData.GetSaleReport();
        }
    }
}

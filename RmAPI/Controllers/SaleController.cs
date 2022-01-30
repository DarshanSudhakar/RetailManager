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
        private readonly IConfiguration _config;

        public SaleController(IConfiguration config)
        {
            _config = config;
        }

        [Authorize(Roles = "Cashier")]
        [HttpPost]
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData(_config);
            var cashierId = User.FindFirstValue(ClaimTypes.NameIdentifier); //Old way - RequestContext.Principal.Identity.GetUserId();
            data.SaveSale(sale, cashierId);
        }

        [Authorize(Roles = "Admin,Manager")]
        [Route("GetSalesReport")]
        [HttpGet]
        public List<SaleReportModel> GetSalesReport()
        {
            SaleData data = new SaleData(_config);

            return data.GetSaleReport();
        }
    }
}

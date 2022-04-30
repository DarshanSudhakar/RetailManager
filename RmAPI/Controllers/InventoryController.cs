using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RmDataManager.Library.DataAccess;
using RmDataManager.Library.Models;
using System.Collections.Generic;

namespace RmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryData _inventoryData;

        public InventoryController(IInventoryData inventoryData)
        {
            _inventoryData = inventoryData;
        }


        [Authorize(Roles = "Admin,Manager")]
        [HttpGet]
        public List<InventoryModel> Get()
        {
            return _inventoryData.GetInventory();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public void Post(InventoryModel item)
        {
            _inventoryData.SaveInventoryRecord(item);
        }
    }
}

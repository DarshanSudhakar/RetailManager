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
    public class InventoryData : IInventoryData
    {
        private readonly ISqlDataAccess _sql;

        public InventoryData(IConfiguration config, ISqlDataAccess sqlDataAccess)
        {
            _sql = sqlDataAccess;
        }

        public List<InventoryModel> GetInventory()
        {
            var output = _sql.LoadData<InventoryModel, dynamic>("dbo.spInventory_GetAll", new { }, "RmData");

            return output;
        }

        public void SaveInventoryRecord(InventoryModel item)
        {
            _sql.SaveData("dbo.spInventory_Insert", item, "RmData");
        }
    }
}

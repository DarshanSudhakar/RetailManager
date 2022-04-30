using RmDataManager.Library.Models;
using System.Collections.Generic;

namespace RmDataManager.Library.DataAccess
{
    public interface IInventoryData
    {
        List<InventoryModel> GetInventory();
        void SaveInventoryRecord(InventoryModel item);
    }
}
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
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _sql;

        public UserData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public UserModel GetUserById(string Id)
        {
            var output = _sql.LoadData<UserModel, dynamic>("RmData.dbo.spUserLookup", new { Id }, "RmData").FirstOrDefault();

            return output;
        }
    }
}

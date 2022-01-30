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
    public class UserData
    {
        private readonly IConfiguration _config;

        public UserData(IConfiguration config)
        {
            _config = config;
        }

        public UserModel GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess(_config);

            var p = new { Id = id };

            var output = sql.LoadData<UserModel, dynamic>("RmData.dbo.spUserLookup", p, "RmData").FirstOrDefault();

            return output;
        }
    }
}

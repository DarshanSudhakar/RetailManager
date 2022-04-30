using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmDesktopUI.Library.Model
{
    public class UserModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public Dictionary<string, string> Roles { get; set; } = new Dictionary<string, string>();

        public string RoleList
        {
            get
            {
                return string.Join(", ", Roles.OrderBy(x => x.Value).Select(x => x.Value));
            }
        }
    }
}

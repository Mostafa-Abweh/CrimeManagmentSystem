using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
    }
}

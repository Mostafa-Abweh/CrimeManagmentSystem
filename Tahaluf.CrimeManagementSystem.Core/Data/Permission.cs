using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class Permission
    {
        public int PermissionId { get; set; }

        public string PermissionName { get; set; }

        public string PermissionDescription { get; set; }

       
        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
    }
}

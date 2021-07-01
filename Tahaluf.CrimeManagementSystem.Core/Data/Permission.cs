using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class Permission
    {
        public int PermissionId { get; set; }

        public int RoleId { get; set; }

        public string PermissionName { get; set; }

        public int PermissionModule { get; set; }

        public virtual Role Roles { get; set; }
    }
}

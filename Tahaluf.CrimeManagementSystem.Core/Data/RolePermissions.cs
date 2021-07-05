using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
  public  class RolePermissions
    {
        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        public virtual Role Role { get; set; }

        public virtual Permission Permission { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string IdentityNumber { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}

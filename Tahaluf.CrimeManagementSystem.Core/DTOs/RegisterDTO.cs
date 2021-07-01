using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.DTOs
{
   public  class RegisterDTO
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string IdentitiyNumber { get; set; }

        public string RoleName { get; set; }


    }
}

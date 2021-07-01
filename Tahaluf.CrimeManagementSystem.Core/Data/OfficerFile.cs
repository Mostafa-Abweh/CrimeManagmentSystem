using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class OfficerFile
    {
        public int CrimeId { get; set; }

        public int OfficerId { get; set; }

        public virtual Crime Crime { get; set; }
        public virtual Officer Officer { get; set; }
    }
}

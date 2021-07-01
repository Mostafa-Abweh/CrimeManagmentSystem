using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class LawyerFile
    {
        public int LawyerId { get; set; }
        public int CrimeId { get; set; }
        public virtual Crime Crime { get; set; }
        public virtual Lawyer Lawyer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class EvidenceFile
    {
        public int EvidenceId { get; set; }
        public int CrimeId { get; set; }
        public virtual Crime Crime { get; set; }
        public virtual Evidence Evidence { get; set; }
    }
}

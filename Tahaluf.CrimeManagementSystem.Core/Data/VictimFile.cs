using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class VictimFile
    {
        public int VictimId { get; set; }
        public int CrimeId { get; set; }
        public virtual Crime Crime { get; set; }
        public virtual Victim Victim { get; set; }
    }
}

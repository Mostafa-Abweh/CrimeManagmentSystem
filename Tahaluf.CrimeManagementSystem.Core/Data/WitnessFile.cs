using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
 public class WitnessFile
    {
        public int CrimeId { get; set; }
        public int WitnessId { get; set; }
        public virtual Crime Crime { get; set; }
        public virtual Witness Witness { get; set; }
  
    }
}

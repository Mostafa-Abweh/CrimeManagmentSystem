using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class Witness
    {
        public int WitnessId { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string IdentityNumber { get; set; }
        public string Notes { get; set; }
        public string Contact { get; set; }
        public virtual ICollection<WitnessFile> WitnessFiles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class Victim
    {
        public int VictimId { get; set; }

        public string Name { get; set; }

        public string MotherName { get; set; }

        public string IdentityNumber { get; set; }

        public string Contact { get; set; }

        public string Notes { get; set; }


        public virtual ICollection<VictimFile> VictimFiles { get; set; }
    }
}

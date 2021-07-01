using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class FirstInformationReport
    {
        public int FIRId { get; set; }
        public string FIRName { get; set; }
        public string Descriotion { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Crime> Crimes { get; set; }
    }
}

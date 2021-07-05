using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class AcussedFile
    {
        public int AcussedId { get; set; }
        public int CrimeId { get; set; }
        public virtual Crime Crime { get; set; }
        public virtual Acussed Acussed { get; set; }
    }
}

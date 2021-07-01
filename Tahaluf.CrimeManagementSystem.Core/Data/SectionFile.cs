using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class SectionFile
    {
        public int SectionId { get; set; }
        public int CrimeId { get; set; }
        public virtual Crime Crime { get; set; }
        public virtual Section Section { get; set; }
    }
}

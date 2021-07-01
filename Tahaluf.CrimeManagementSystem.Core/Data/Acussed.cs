using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
  public class Acussed
    {
        public int AcussedId { get; set; }

        public string Name { get; set; }

        public string MotherName { get; set; }

        public string IdentityNumber{ get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public string Notes { get; set; }

        public string CrimeFileNumber { get; set; }

        public virtual ICollection<AcussedFile> AcussedFiles { get; set; }
    }
}

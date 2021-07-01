using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
  public  class Evidence
    {
        public int EvidenceId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<EvidenceFile> EvidenceFiles { get; set; }
    }
}

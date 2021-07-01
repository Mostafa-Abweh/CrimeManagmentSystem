using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class Section
    {
        public int SectionId { get; set; }

        public string SectionName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SectionFile> SectionFiles { get; set; }
    }
}

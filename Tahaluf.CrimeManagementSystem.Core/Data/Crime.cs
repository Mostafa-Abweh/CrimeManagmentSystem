using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class Crime
    {
        public int CrimeId { get; set; }

        public DateTime DateOfOffence { get; set; }

        public string Report { get; set; }

        public DateTime DateOfReport { get; set; }

        public string CaseStatus { get; set; }

        public DateTime TimeOfCrime { get; set; }

        public string Description { get; set; }

        public int FIRId { get; set; }

        public string Location { get; set; }

        public string CrimeTitle { get; set; }

        public DateTime CloseDate { get; set; }

        public virtual ICollection<JudgeFile> JudgeFiles { get; set; }
      
         public virtual ICollection<VictimFile> VictimFiles { get; set; }
        public virtual ICollection<PoliceStationFile> PoliceStationFiles { get; set; }
        public virtual ICollection<OfficerFile> OfficerFiles { get; set; }
        public virtual ICollection<WitnessFile> WitnessFiles { get; set; }
      
        public virtual ICollection<LawyerFile> LawyerFiles { get; set; }
      
        public virtual ICollection<EvidenceFile> EvidenceFiles { get; set; }
      
        public virtual ICollection<AcussedFile> AcussedFiles { get; set; }
      
        public virtual ICollection<SectionFile> SectionFiles { get; set; }
     
         public virtual FirstInformationReport FirstInformationReports { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.DTOs
{
   public class CrimeDTO
    {
        public string CrimeTtile { get; set; }
        public string SortType { get; set; }
        public string SortingCol { get; set; }
        public string Location { get; set; }
        public int? JudgeId { get; set; }
        public int? SectionId { get; set; }
        public int? AcussedId { get; set; }
        public int? WitnessId { get; set; }
        public int? VictimId { get; set; }
        public int? OfficerId { get; set; }
        public int? LawyerId { get; set; }
        public int? EvidenceId { get; set; }
        public int? PoliceStationId { get; set; }
        public int? PageNumber { get; set; }
        public int? RowsOfPage { get; set; }
        public int? TotalCount { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

    }
}

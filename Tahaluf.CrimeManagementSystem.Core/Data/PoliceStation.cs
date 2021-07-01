using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class PoliceStation
    {
        public int PoliceStationId { get; set; }
        public string PSName { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public int NumberOfStuff { get; set; }

        public virtual ICollection<OfficerStation> OfficerStations { get; set; }
        public virtual ICollection<PoliceStationFile> PoliceStationFiles { get; set; }
    }
}

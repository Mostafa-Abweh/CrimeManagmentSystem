using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class PoliceStationFile
    {
        public int CrimeId { get; set; }
        public int PoliceStationId { get; set; }

        public Crime crime { get; set; }
        public PoliceStation policeStation { get; set; }
    }
}

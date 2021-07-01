using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class OfficerStation
    {
        public int PoliceStationId { get; set; }
        public int OfficerId { get; set; }
        public virtual Officer Officer { get; set; }
        public virtual PoliceStation PoliceStation { get; set; }
    }
}

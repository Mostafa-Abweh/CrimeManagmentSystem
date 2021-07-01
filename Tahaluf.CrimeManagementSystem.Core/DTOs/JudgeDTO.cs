using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.DTOs
{
    public class JudgeDTO
    {
        public string JudgeName { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public string CrimeTitle { get; set; }
    }
}

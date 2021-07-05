using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
   public class JudgeFile
    {
        public int CrimeId { get; set; }
        public int JudgeId { get; set; } 
        public virtual Judge Judge { get; set; }
        public virtual Crime Crime { get; set; }
    }
}

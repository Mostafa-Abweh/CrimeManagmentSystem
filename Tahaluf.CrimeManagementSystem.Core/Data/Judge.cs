using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
  public  class Judge
    {
        public int JudgeId { get; set; }

        public string Name { get; set; }

        public string MotherName { get; set; }

        public string IdentityNumber { get; set; }

        public string Address { get; set; }

        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfHire { get; set; }
        public string Description { get; set; }

        public string Qualification { get; set; }

        public char Gender { get; set; }

        public virtual ICollection<JudgeFile> JudgeFiles { get; set; }

    }
}

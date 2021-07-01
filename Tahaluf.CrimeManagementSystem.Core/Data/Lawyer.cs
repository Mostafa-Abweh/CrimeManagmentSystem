using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class Lawyer
    {
        public int LawyerId { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public string IdentityNumber { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfHire { get; set; }
        public string Descriptopn { get; set; }
        public string Qualification { get; set; }

       public virtual ICollection<LawyerFile> LawyerFiles { get; set; }
    }
}

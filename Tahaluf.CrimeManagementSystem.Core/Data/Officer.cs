using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.CrimeManagementSystem.Core.Data
{
    public class Officer
    {
        public int OfficerId { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public string IdentityNumber { get; set; }
        public string Badgenumber { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        public string Emaill { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfHire { get; set; }
        public string Qualification { get; set; }
        public string Descriptopn { get; set; }

        public virtual ICollection<OfficerFile> OfficerFiles { get; set; }
    }
}

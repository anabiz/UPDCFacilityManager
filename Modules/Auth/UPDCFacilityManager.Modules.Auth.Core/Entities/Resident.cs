using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Resident
    {
        public Resident() 
        {
            Emails = new HashSet<Email>();
            PhoneNumbers = new HashSet<Phone>();
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UnitId { get; set; }
        public string EstateId { get; set; }
        public Unit Unit { get; set; }
        public Estate Estate { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<Phone> PhoneNumbers { get; set; }
    }
}

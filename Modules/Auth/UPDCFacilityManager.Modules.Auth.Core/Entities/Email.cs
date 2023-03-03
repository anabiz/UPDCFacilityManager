using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Email
    {
        public string Id { get; set; }
        public string EmailAddress { get; set; }
        public string ResidenceId { get; set; }  
        public Resident Residence { get; set; }
    }
}

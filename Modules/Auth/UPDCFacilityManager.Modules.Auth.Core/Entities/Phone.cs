using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Auth.Core.Entities
{
    public class Phone
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string ResidenceId { get; set; }
        public Resident Residence { get; set; }
    }
}

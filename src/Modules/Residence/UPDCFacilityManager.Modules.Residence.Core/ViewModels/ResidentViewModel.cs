using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Residence.Core.ViewModels
{
    public class ResidentViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Unit { get; set; }
        public string Estate { get; set; }
        public string Cluster { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

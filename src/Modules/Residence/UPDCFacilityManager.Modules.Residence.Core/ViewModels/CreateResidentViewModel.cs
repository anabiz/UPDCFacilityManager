using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Residence.Core.ViewModels
{
    public class CreateResidentViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UnitId { get; set; }
        [Required]
        public string EstateId { get; set; }
        [Required]
        public string ClusterId { get; set; }
        [Required]
        [EmailAddress]
        public string FirstEmail { get; set; }
        [EmailAddress]
        public string? SecondEmail { get; set; }
        [Required]
        public string FirstPhone { get; set; }
        public string? SecondPhone { get; set; }
    }
}

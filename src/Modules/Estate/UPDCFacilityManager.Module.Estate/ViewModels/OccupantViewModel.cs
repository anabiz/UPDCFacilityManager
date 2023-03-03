using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Entities;

namespace UPDCFacilityManager.Module.Estates.ViewModels
{
    public class OccupantViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UnitName { get; set; }
        public string Code { get; set; }
        public string Status { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

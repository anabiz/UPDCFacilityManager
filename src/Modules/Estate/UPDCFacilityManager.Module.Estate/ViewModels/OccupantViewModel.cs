using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.ViewModels
{
    public class OccupantViewModel : UpdateOccupantViewModal
    {
        public string Id { get; set; }
        public string UnitName { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string UnitId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

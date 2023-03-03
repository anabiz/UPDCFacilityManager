using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Module.Estates.ViewModels;

namespace UPDCFacilityManager.Modules.Estates.ViewModels
{
    public class UnitViewModel
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Estate { get; set; }
        public string Cluster { get; set; }
        public List<OccupantViewModel> Occupants { get;} = new List<OccupantViewModel>();
    }
}

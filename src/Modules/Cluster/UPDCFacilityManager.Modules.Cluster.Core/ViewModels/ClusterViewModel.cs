using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Modules.Cluster.Core.ViewModels
{
    public class ClusterViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EstateViewModel> Estates { get; set; }
    }


}

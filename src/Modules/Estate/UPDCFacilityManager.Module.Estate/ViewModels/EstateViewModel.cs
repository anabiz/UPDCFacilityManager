using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Modules.Estates.ViewModels
{
    public class EstateViewModel : CreateEstateViewModel
    {
        public string Id { get; set; }
        public List<UnitViewModel> Units { get; set; } 
    }
}

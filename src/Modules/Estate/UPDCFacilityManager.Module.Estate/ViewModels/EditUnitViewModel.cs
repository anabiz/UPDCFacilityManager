using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.ViewModels
{
    public class EditUnitViewModel : CreateUnitViewModel
    {
        public string EstateId { get; set; }
    }
}

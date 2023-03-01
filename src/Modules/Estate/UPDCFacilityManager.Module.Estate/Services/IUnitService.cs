using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Services
{
    public interface IUnitService
    {
        Task<List<UnitViewModel>> BrowseAsync();
        Task<string> CreateAsync(CreateUnitViewModel model, string estateId);
    }
}

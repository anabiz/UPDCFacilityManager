using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Module.Estates.ViewModels;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Services
{
    public interface IUnitService
    {
        Task<List<UnitViewModel>> BrowseAsync();
        Task<EstateViewModel> GetUnitsAsync(string estateId, string? search=null);
        Task DeleteUnitAsync(string UnitId);
        Task DeleteOccupantAsync(string occupantId);
        Task<OccupantViewModel> GetOccupantByIdAsync(string occupantId);
        Task<string> CreateAsync(CreateUnitViewModel model, string estateId);
        Task<UnitViewModel> GetUnitOccupantsAsync(string unitId, string? search = null);
        Task<UnitViewModel> CreateOccupantAsync(CreateOccupantViewModel model, string unitId);

    }
}

using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Modules.Estates.Services
{
    public interface IEstateService
    {
        Task<List<EstateViewModel>> BrowseAsync();
        Task<EstateViewModel> CreateAsync(CreateEstateViewModel model, string clusterId);
        Task UpdateAsync(UpdateEstateViewModel model);
        Task<EstateViewModel> GetEstatesById(string id);
        Task<ClusterEstateViewModel> GetEstatesByClusterId(string id, string search);
    }
}

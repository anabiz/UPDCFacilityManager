
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Cluster.Core.Services
{
    public interface IClusterService
    {
        //Task<IEnumerable<UserViewModel>> BrowseAsync();
        //Task<UserViewModel> GetAsync(string userId);
        Task CreateAsync(CreateClusterViewModel model);
        Task UpdateAsync(UpdateClusterViewModel model);
    }
}

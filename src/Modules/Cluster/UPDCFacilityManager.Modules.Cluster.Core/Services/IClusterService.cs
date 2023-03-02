
using Microsoft.AspNetCore.Mvc;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Cluster.Core.Services
{
    public interface IClusterService
    {
        Task<List<ClusterViewModel>> BrowseAsync(string? search = null);
        //Task<UserViewModel> GetAsync(string userId);
        Task CreateAsync(CreateClusterViewModel model);
        Task UpdateAsync(UpdateClusterViewModel model);
         
    }
}

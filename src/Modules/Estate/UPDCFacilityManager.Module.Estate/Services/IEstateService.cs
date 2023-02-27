﻿using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Modules.Estates.Services
{
    public interface IEstateService
    {
        Task<List<EstateViewModel>> BrowseAsync();
        //Task<UserViewModel> GetAsync(string userId);
        Task<EstateViewModel> CreateAsync(CreateEstateViewModel model, string clusterId);
        Task UpdateAsync(UpdateEstateViewModel model);
        Task<EstateViewModel> GetEstatesById(string id);
        Task<EstateViewModel> GetUnitsAsync(string estateId);
    }
}

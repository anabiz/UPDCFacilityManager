using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.ViewModels;
using UPDCFacilityManager.Modules.Residence.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Auth.Core.Services
{
    public interface IResidentService
    {
        //Task<IEnumerable<UserViewModel>> BrowseAsync();
        //Task<UserViewModel> GetAsync(string userId);
        Task CreateAsync(CreateResidentViewModel model);
        Task UpdateAsync(UpdateResidentViewModel model);
    }
}

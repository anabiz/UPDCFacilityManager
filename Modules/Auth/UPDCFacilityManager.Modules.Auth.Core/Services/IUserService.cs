using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Auth.Core.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> BrowseAsync();
        Task<UserViewModel> GetAsync(string userId);
        Task CreateAsync(RegisterViewModel model);
        Task UpdateAsync(RegisterViewModel model);
    }
}

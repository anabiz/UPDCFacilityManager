using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Auth.Core.Services
{
    public class UserService : IUserService
    {
        public Task<IEnumerable<UserViewModel>> BrowseAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> GetAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Repositories;
using UPDCFacilityManager.Modules.Auth.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Auth.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;
        private readonly IMapper _mapper;

        public UserService(
            IUserRepository userRepository,
            ILogger<UserService> logger,
            IMapper mapper
            )
        {
            _userRepository = userRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public IMapper Mapper { get; }

        public async Task<IEnumerable<UserViewModel>> BrowseAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserViewModel>>( users );

        }

        public Task CreateAsync(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<UserViewModel> GetAsync(string userId)
        {
            var user =  await _userRepository.GetByIdAsync( userId );
            if ( user == null )
            {
                Console.WriteLine("emptyyyyyyy");
            }
            return _mapper.Map<UserViewModel>( user );
        }

        public Task UpdateAsync(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Auth.Core.Repositories;
using UPDCFacilityManager.Modules.Auth.Core.ViewModels;
using UPDCFacilityManager.Modules.Residence.Core.Repositories;
using UPDCFacilityManager.Modules.Residence.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Auth.Core.Services
{
    public class ResidentService : IResidentService
    {
        private readonly IResidentRepository _residentRepository;
        private readonly ILogger<UserService> _logger;
        private readonly IMapper _mapper;

        public ResidentService(
            IResidentRepository residentRepository,
            ILogger<UserService> logger,
            IMapper mapper
            )
        {
            _residentRepository = residentRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateResidentViewModel model)
        {
            Resident resident = _mapper.Map<Resident>(model);
            resident.Id = Guid.NewGuid().ToString();
            await _residentRepository.AddAsync(resident);

        }

        public Task UpdateAsync(UpdateResidenceViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

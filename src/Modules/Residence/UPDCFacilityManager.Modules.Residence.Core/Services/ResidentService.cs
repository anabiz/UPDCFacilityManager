using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Data;
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
        private readonly ILogger<ResidentService> _logger;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ResidentService(
            IResidentRepository residentRepository,
            ILogger<ResidentService> logger,
            AppDbContext appDbContext,
            IMapper mapper
            )
        {
            _residentRepository = residentRepository;
            _logger = logger;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        public async Task CreateAsync(CreateResidentViewModel model)
        {
            Resident resident = _mapper.Map<Resident>(model);
            resident.Id = Guid.NewGuid().ToString();
            await _residentRepository.AddAsync(resident);

            var email = new Email
            {
                Id = Guid.NewGuid().ToString(),
                EmailAddress = model.FirstEmail,
                ResidenceId = resident.Id
            };

            var phone = new Phone
            {
                Id = Guid.NewGuid().ToString(),
                PhoneNumber = model.FirstPhone,
                ResidenceId = resident.Id
            };

            _appDbContext.Emails.Add(email);
            _appDbContext.Phones.Add(phone);
            _appDbContext.SaveChanges();


        }

        public Task UpdateAsync(UpdateResidenceViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

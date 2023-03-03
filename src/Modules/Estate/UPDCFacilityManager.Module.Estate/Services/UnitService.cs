using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Module.Estates.ViewModels;
using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Estates.Services;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Services
{
    public class UnitService : IUnitService
    {
        private readonly ILogger<EstateService> _logger;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;
        public UnitService(
            AppDbContext appDbContext,
            ILogger<EstateService> logger,
            IMapper mapper
            ) 
        {
            _appDbContext = appDbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public Task<List<UnitViewModel>> BrowseAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> CreateAsync(CreateUnitViewModel model, string estateId)
        {
            Unit newUnit = _mapper.Map<Unit>(model);
            newUnit.Id = Guid.NewGuid().ToString();
            newUnit.EstateId = estateId;
            await _appDbContext.Units.AddAsync(newUnit);
            _appDbContext.SaveChanges();

            return "Unit Creation was Successful";
        }

        public async Task<UnitViewModel> CreateOccupantAsync(CreateOccupantViewModel model, string unitId)
        {
            var occupant = _mapper.Map<Occupant>(model);
            occupant.Id = Guid.NewGuid().ToString();
            occupant.UnitId = unitId;

            Random rnd = new Random();
            int randomNo = rnd.Next(10000000, 99999999);

            occupant.Code = randomNo.ToString();

            await _appDbContext.Occupants.AddAsync(occupant);  
            _appDbContext.SaveChanges();

            var unit = _appDbContext.Units.Where(x => x.Id== unitId)
                  .Include(x => x.Occupants)
                  .FirstOrDefault();

            return _mapper.Map<UnitViewModel>(unit);
        }

        public async Task<UnitViewModel> GetUnitOccupantsAsync(string unitId, string? search = null)
        {
            var units = await _appDbContext.Units.Where(x => x.Id == unitId)
            .Include(x => x.Occupants)
            .FirstOrDefaultAsync();

            if (!string.IsNullOrEmpty(search))
            {
                IEnumerable<Occupant> occupants = units!.Occupants.Where(x => x.Email.ToLower().Contains(search.ToLower()));
                units.Occupants = occupants.ToList();
            }

            return _mapper.Map<UnitViewModel>(units);
        }

        public async Task<EstateViewModel> GetUnitsAsync(string estateId, string search)
        {
            var estate = await _appDbContext.Estates.Where(x => x.Id == estateId)
               .Include(x => x.Units)
               .Include(x => x.Cluster)
               .FirstOrDefaultAsync();

            if (!string.IsNullOrEmpty(search))
            {
                IEnumerable<Unit> units = estate!.Units.Where(x => x.Name.ToLower().Contains(search.ToLower()));
                estate.Units = units.ToList();
            }

            return _mapper.Map<EstateViewModel>(estate);
        }
    }
}

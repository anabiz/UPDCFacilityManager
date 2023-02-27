using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Estates.ViewModels;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Estates.Services
{
    public class EstateService : IEstateService
    {
        private readonly ILogger<EstateService> _logger;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;

        public EstateService(
             AppDbContext appDbContext,
            ILogger<EstateService> logger,
            IMapper mapper
            )
        {
           _appDbContext = appDbContext;
           _logger = logger;
           _mapper = mapper;
        }

        public Task<List<EstateViewModel>> BrowseAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<EstateViewModel> GetUnitsAsync( string estateId)
        {
            var estate = await _appDbContext.Estates.Where(x => x.Id == estateId)
               .Include(x => x.Units)
               .Include(x => x.Cluster)
               .FirstOrDefaultAsync();

            return _mapper.Map<EstateViewModel>(estate);
        }

        public async Task<EstateViewModel> CreateAsync(CreateEstateViewModel model, string Id)
        {
            Estate newEstate = _mapper.Map<Estate>(model);
            newEstate.Id = Guid.NewGuid().ToString();
            newEstate.ClusterId = Id;
            await _appDbContext.Estates.AddAsync(newEstate);
            _appDbContext.SaveChanges();

            return _mapper.Map<EstateViewModel>(await _appDbContext.Estates.FirstOrDefaultAsync(x => x.Id == newEstate.Id));
        }

        public Task<EstateViewModel> GetEstatesById(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateEstateViewModel model)
        {
            throw new NotImplementedException();
        }
        public async Task<ClusterEstateViewModel> GetEstatesByClusterId(string id)
        {
            var clusterEstates = await _appDbContext.Clusters.Where(x => x.Id == id)
                .Include(x => x.Estates).FirstOrDefaultAsync();

            var result = _mapper.Map<ClusterEstateViewModel>(clusterEstates);

            return result;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Cluster.Core.Repositories;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;


namespace UPDCFacilityManager.Modules.Cluster.Core.Services
{
    public class ClusterService : IClusterService
    {
        private readonly IClusterRepository _clusterRepository;
        private readonly ILogger<ClusterService> _logger;
        private readonly IMapper _mapper;

        public ClusterService(
            IClusterRepository clusterRepository,
            ILogger<ClusterService> logger,
            IMapper mapper
            )
        {
            _clusterRepository = clusterRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<ClusterViewModel>> BrowseAsync(string search)
        {
            var clusters = _clusterRepository.QueryAll();
            if (!string.IsNullOrEmpty(search))
            {
                clusters = clusters.Where(x => x.Name.ToLower().Contains(search.ToLower()));
            }
            return _mapper.Map<List<ClusterViewModel>>( await clusters.ToListAsync() );
        }

        public async Task CreateAsync(CreateClusterViewModel model)
        {
            Clusta cluster = _mapper.Map<Clusta>(model);
            cluster.Id = Guid.NewGuid().ToString();
            await _clusterRepository.AddAsync(cluster);
            await _clusterRepository.SaveChangesAsync();
        }

        public Task UpdateAsync(UpdateClusterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

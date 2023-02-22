using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Auth.Core.Repositories;

namespace UPDCFacilityManager.Modules.Cluster.Core.Repositories
{
    public class ClusterRepository : Repository<Clusta>, IClusterRepository
    {
        public ClusterRepository(AppDbContext context) : base(context)
        {
        }
    }
}

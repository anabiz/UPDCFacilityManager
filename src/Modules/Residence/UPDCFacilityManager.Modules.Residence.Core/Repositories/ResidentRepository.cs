using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Auth.Core.Repositories;

namespace UPDCFacilityManager.Modules.Residence.Core.Repositories
{
    public class ResidentRepository : Repository<Resident>, IResidentRepository
    {
        public ResidentRepository(AppDbContext context) : base(context)
        {
        }
    }
}

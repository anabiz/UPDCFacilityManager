using AutoMapper;
using UPDCFacilityManager.Modules.Estates.ViewModels;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Estates.Mapper
{
    public class EstateMapper : Profile
    {
        public EstateMapper()
        {
            CreateMap<CreateEstateViewModel, Estate>();
            CreateMap<Estate, EstateViewModel>();

            CreateMap<Clusta, ClusterEstateViewModel>();
        }
    }
}

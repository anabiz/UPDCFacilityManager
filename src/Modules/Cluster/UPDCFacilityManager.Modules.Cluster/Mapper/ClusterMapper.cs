using AutoMapper;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Cluster.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Cluster.Mapper
{
    public class ClusterMapper : Profile
    {
        public ClusterMapper()
        {
            CreateMap<CreateClusterViewModel, Clusta>();
                //.ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email.Trim()));

            CreateMap<Clusta, ClusterViewModel>();
        }
    }
}

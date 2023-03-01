using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Mapper
{
    public class UnitMapper : Profile
    {
        public UnitMapper() 
        {
            CreateMap<CreateUnitViewModel, Unit>();

            CreateMap<Unit, UnitViewModel>()
               .ForMember(dest => dest.Estate, opt => opt.MapFrom(src => src.Estate.Name))
               .ForMember(dest => dest.Cluster, opt => opt.MapFrom(src => src.Estate.Cluster.Name));
        }
    }
}

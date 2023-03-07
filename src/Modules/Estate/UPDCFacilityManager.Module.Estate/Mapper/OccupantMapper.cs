using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Module.Estates.ViewModels;

namespace UPDCFacilityManager.Module.Estates.Mapper
{
    public class OccupantMapper : Profile
    {
        public OccupantMapper()
        {
            CreateMap<CreateOccupantViewModel, Occupant>();

            CreateMap<Occupant, OccupantViewModel>()
                .ForMember(dest => dest.UnitName, opt => opt.MapFrom(src => src.Unit.Name))
                 .ForMember(dest => dest.UnitId, opt => opt.MapFrom(src => src.Unit.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.AccuntStatus));

            CreateMap<Occupant, UpdateOccupantViewModal>()
                 .ForMember(dest => dest.UnitId, opt => opt.MapFrom(src => src.Unit.Id));
        }
    }
}

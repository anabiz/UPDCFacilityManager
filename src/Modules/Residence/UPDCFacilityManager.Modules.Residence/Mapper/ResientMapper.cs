using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Auth.Core.ViewModels;
using UPDCFacilityManager.Modules.Residence.Core.ViewModels;

namespace UPDCFacilityManager.Modules.Residence.Mapper
{
    public class ResidentMapper : Profile
    {
        public ResidentMapper()
        {
            CreateMap<CreateResidentViewModel, Resident>();

            CreateMap<UpdateResidentViewModel, Resident>();

            CreateMap<Resident, ResidentViewModel>()
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.PhoneNumbers.ToList()[0].PhoneNumber))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Unit.Name))
                .ForMember(dest => dest.Estate, opt => opt.MapFrom(src => src.Estate.Name))
                .ForMember(dest => dest.Cluster, opt => opt.MapFrom(src => src.Estate.Cluster.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Emails.ToList()[0].EmailAddress)); 


        }
    }
}

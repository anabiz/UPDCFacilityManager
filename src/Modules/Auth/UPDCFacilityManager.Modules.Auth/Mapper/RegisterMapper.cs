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

namespace UPDCFacilityManager.Modules.Auth.Mapper
{
    public class RegisterMapper : Profile
    {
        public RegisterMapper()
        {
            CreateMap<RegisterViewModel, AppUser>();
                //.ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email.Trim()));
        }
    }
}

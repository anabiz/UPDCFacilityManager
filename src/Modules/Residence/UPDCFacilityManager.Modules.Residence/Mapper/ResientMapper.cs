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

        }
    }
}

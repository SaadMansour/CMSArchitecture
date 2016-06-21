using AutoMapper;
using CMS.Models;
using CMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core.Mapping
{
    public class ModelToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Patient, PatientViewModel>()
                .ForMember(vm => vm.FullName, 
                map => map.MapFrom(pm => pm.FirstName + " " + pm.LastName));
        }
    }
}

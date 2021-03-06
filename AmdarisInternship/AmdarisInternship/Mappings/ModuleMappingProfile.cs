﻿using AmdarisInternship.API.Dtos;
using AmdarisInternship.Domain.Entities;
using AutoMapper;

namespace AmdarisInternship.API.Mappings
{
    public class ModuleMappingProfile : Profile
    {
        public ModuleMappingProfile()
        {
            CreateMap<Module, ModuleDto>();
            CreateMap<ModuleDto, Module>();



            CreateMap<ModuleGrading, ModuleGradingDto>();
            CreateMap<ModuleGradingDto, ModuleGrading>();

            

            
        }
    }
}

using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Exceptions;
using AmdarisInternship.Domain.Entities;
using AutoMapper;

namespace AmdarisInternship.API.Mappings
{
    public class ModuleMappingProfile : Profile
    {
        public ModuleMappingProfile()
        {
            CreateMap<Module, ModuleDto>();
            CreateMap<CreateModuleDto, Module>();


            CreateMap<ModuleGrading, ModuleGradingDto>();

            

            
        }
    }
}

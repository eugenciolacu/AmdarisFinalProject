using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Models;
using AmdarisInternship.API.Services.Interfaces;
using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Infrastructure.Context;
using AmdarisInternship.Infrastructure.Repositories;
using AmdarisInternship.Infrastructure.Repositories.CustomRepositories;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services
{
    public class ModuleModuleGradingsService : IModuleModuleGradingsService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly IRepository<ModuleGrading> _moduleGradingRepository;

        private readonly IMapper _mapper;

        public ModuleModuleGradingsService(IMapper mapper, IModuleRepository moduleRepository, IRepository<ModuleGrading> moduleGradingRepository)
        {
            _mapper = mapper;
            _moduleRepository = moduleRepository;
            _moduleGradingRepository = moduleGradingRepository;
        }

        public IList<ModuleWithModuleGradingDto> GetModulesWithModuleGradings()
        {
            var modules = _moduleRepository.GetModulesWithModuleGradings();

            IList<ModuleWithModuleGradingDto> result = new List<ModuleWithModuleGradingDto>();

            foreach (var item in modules)
            {
                ModuleWithModuleGradingDto moduleWithGradingDto = new ModuleWithModuleGradingDto();
                moduleWithGradingDto.Module = _mapper.Map<ModuleDto>(item);

                foreach (var moduleGrading in item.ModuleGradings)
                {
                    moduleWithGradingDto.ModuleGradings.Add(_mapper.Map<ModuleGradingDto>(moduleGrading));
                }

                result.Add(moduleWithGradingDto);
            }

            return result;
        }

        public void AddNewModuleModuleGradingAsync(ModuleWithModuleGradingDto dto)
        {
            Module module = _mapper.Map<Module>(dto.Module);

            _moduleRepository.Add(module);
            _moduleRepository.Save();

            List<ModuleGrading> moduleGradings = new List<ModuleGrading>();

            for (int i = 0; i < dto.ModuleGradings.Count; i++)
            {
                ModuleGrading moduleGrading = new ModuleGrading
                {
                    Name = dto.ModuleGradings[i].Name,
                    Weight = dto.ModuleGradings[i].Weight,
                    ModuleId = module.Id
                };

                moduleGradings.Add(moduleGrading);
                _moduleGradingRepository.Add(moduleGrading);
            }
            _moduleGradingRepository.Save();
        }    
    }
}

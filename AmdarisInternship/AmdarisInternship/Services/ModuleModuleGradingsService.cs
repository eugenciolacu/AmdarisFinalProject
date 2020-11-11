using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Models;
using AmdarisInternship.API.Services.Interfaces;
using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Infrastructure.Context;
using AmdarisInternship.Infrastructure.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services
{
    public class ModuleModuleGradingsService : IModuleModuleGradingsService
    {
        private readonly IRepository<Module> _moduleRepository;
        private readonly IRepository<ModuleGrading> _moduleGradingRepository;

        private readonly AmdarisInternshipContext _appContext;
        private readonly IMapper _mapper;

        public ModuleModuleGradingsService(AmdarisInternshipContext appContext, IMapper mapper, IRepository<Module> moduleRepository, IRepository<ModuleGrading> moduleGradingRepository)
        {
            _appContext = appContext;
            _mapper = mapper;
            _moduleRepository = moduleRepository;
            _moduleGradingRepository = moduleGradingRepository;
        }

        public async Task<(Module, List<ModuleGrading>)> AddNewModuleModuleGradingAsync(CreateModuleModuleGradingDto dto)
        {
            await using var transaction = await _appContext.Database.BeginTransactionAsync();

            try
            {
                (Module module, List<ModuleGrading> moduleGradings) result;

                Module module = _mapper.Map<Module>(dto.CreateModuleDto);
                
                _moduleRepository.Add(module);
                _moduleRepository.Save();

                List<ModuleGrading> moduleGradings = new List<ModuleGrading>();

                for (int i = 0; i < dto.CreateModuleGradingDtos.Count; i++)
                {
                    ModuleGrading moduleGrading = new ModuleGrading
                    {
                        Name = dto.CreateModuleGradingDtos[i].Name,
                        Weight = dto.CreateModuleGradingDtos[i].Weight,
                        ModuleId = module.Id
                    };

                    moduleGradings.Add(moduleGrading);
                    _moduleGradingRepository.Add(moduleGrading);
                }
                _moduleGradingRepository.Save();

                result.module = module;
                result.moduleGradings = moduleGradings;

                await transaction.CommitAsync();

                return result;
            }
            catch
            {
                await transaction.RollbackAsync();
                return (null, null);
            }
        }
        
    }
}

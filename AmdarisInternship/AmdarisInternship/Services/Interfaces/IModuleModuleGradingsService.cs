using AmdarisInternship.API.Dtos;
using AmdarisInternship.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services.Interfaces
{
    public interface IModuleModuleGradingsService
    {
        ModuleWithModuleGradingDto AddNewModuleWithModuleGrading(ModuleWithModuleGradingDto dto);

        IList<ModuleWithModuleGradingDto> GetModulesWithModuleGradings();

        ModuleWithModuleGradingDto GetModuleWithModuleGradingsByModuleId(int id);

        ModuleWithModuleGradingDto UpdateModuleWithModuleGrading(int id, ModuleWithModuleGradingDto dto);
    }
}

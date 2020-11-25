using AmdarisInternship.API.Dtos;
using System.Collections.Generic;

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

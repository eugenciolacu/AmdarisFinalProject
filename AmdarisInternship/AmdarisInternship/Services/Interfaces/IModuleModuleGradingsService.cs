using AmdarisInternship.API.Dtos;
using AmdarisInternship.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services.Interfaces
{
    public interface IModuleModuleGradingsService
    {
        void AddNewModuleModuleGradingAsync(ModuleWithModuleGradingDto dto);

        IList<ModuleWithModuleGradingDto> GetModulesWithModuleGradings();
    }
}

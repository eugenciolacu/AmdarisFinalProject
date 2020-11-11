using AmdarisInternship.API.Dtos;
using AmdarisInternship.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Services.Interfaces
{
    public interface IModuleModuleGradingsService
    {
        Task<(Module, List<ModuleGrading>)> AddNewModuleModuleGradingAsync(CreateModuleModuleGradingDto dto);
    }
}

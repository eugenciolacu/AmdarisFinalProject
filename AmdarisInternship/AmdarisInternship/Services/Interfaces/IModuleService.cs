using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Models;
using AmdarisInternship.Domain.Entities;
using System.Collections.Generic;

namespace AmdarisInternship.API.Services
{
    public interface IModuleService
    {
        IList<Module> GetModules(FilterOptions filterOptions);

        Module GetModuleById(int id);

        Module AddNewModule(ModuleDto dto);

        Module UpdateModuleDetails(int id, ModuleDto dto);

        Module UpdateModule(int id, ModuleDto dto);

        bool RemoveModuleById(int id);
    }
}

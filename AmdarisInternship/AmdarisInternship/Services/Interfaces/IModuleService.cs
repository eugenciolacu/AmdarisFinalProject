﻿using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Models;
using AmdarisInternship.Domain.Entities;
using System.Linq;

namespace AmdarisInternship.API.Services
{
    public interface IModuleService
    {
        IQueryable<Module> GetModules(FilterOptions filterOptions);

        Module GetModuleById(int id);

        Module AddNewModule(CreateModuleDto dto);

        Module UpdateModuleDetails(int id, UpdateModuleDto dto);

        Module UpdateModule(int id, CreateModuleDto dto);

        bool RemoveModuleById(int id);
    }
}

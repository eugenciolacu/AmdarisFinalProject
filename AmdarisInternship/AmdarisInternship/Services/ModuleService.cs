using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Exceptions;
using AmdarisInternship.API.Models;
using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Infrastructure.Repositories;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace AmdarisInternship.API.Services
{
    public class ModuleService : IModuleService
    {
        private readonly IRepository<Module> _moduleRepository;

        public ModuleService(IRepository<Module> moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }

        public Module AddNewModule(ModuleDto dto)
        {
            if (CheckIfNameExists(dto.Name))
            {
                throw new EntryAlreadyExistsException("There is module with this name already");
            }

            Module module = new Module
            {
                Name = dto.Name
            };

            _moduleRepository.Add(module);
            _moduleRepository.Save();

            return module;
        }

        public Module GetModuleById(int id)
        {
            return _moduleRepository.Find(id);
        }

        public IList<Module> GetModules(FilterOptions filterOptions)
        {
            IQueryable<Module> modules;

            if (!string.IsNullOrWhiteSpace(filterOptions.SearchTerm))
            {
                modules = _moduleRepository.FindAll(m => m.Name.Contains(filterOptions.SearchTerm));
            }
            else
            {
                modules = _moduleRepository.GetAll();
            }

            switch (filterOptions.Order)
            {
                case SortOrder.Ascending:
                    modules = modules.OrderBy(m => m.Name);
                    break;
                case SortOrder.Descending:
                    modules = modules.OrderByDescending(m => m.Name);
                    break;
            }

            return modules.ToList();
        }

        public bool RemoveModuleById(int id)
        {
            Module module = _moduleRepository.Find(id);

            if (module != null)
            {
                _moduleRepository.Delete(module);
                _moduleRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Module UpdateModule(int id, ModuleDto dto)
        {
            Module module = _moduleRepository.Find(id);

            if (module == null)
            {
                throw new NotFoundException("Module not found");
            }
            else if (CheckIfNameExists(dto.Name))
            {
                throw new EntryAlreadyExistsException("There is module with this name already");
            }

            if (string.IsNullOrWhiteSpace(dto.Name) == false)
            {
                module.Name = dto.Name;
            }
            else
            {
                throw new UnacceptableEntryException("Unacceptable values");
            }

            _moduleRepository.Save();

            return module;
        }

        public Module UpdateModuleDetails(int id, ModuleDto dto)
        {
            Module module = _moduleRepository.Find(id);

            if (module == null)
            {
                throw new NotFoundException("Module not found");
            }
            else if (CheckIfNameExists(dto.Name))
            {
                throw new EntryAlreadyExistsException("There is module with this name already");
            }

            if (string.IsNullOrWhiteSpace(dto.Name) == false)
            {
                module.Name = dto.Name;
            }
            else
            {
                throw new UnacceptableEntryException("Unacceptable values");
            }

            _moduleRepository.Save();

            return module;
        }

        private bool CheckIfNameExists (string name)
        {
            return _moduleRepository.Find(x => x.Name == name) != null;
        }
    }
}

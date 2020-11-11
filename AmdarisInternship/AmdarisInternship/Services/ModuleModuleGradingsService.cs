using AmdarisInternship.API.Models;
using AmdarisInternship.API.Services.Interfaces;
using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Infrastructure.Repositories;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace AmdarisInternship.API.Services
{
    public class ModuleModuleGradingsService : IModuleModuleGradingsService
    {
        private readonly IRepository<Module> _moduleRepository;
        private readonly IRepository<ModuleGrading> _moduleGradingRepository;

        public ModuleModuleGradingsService(IRepository<Module> moduleRepository, IRepository<ModuleGrading> moduleGradingRepository)
        {
            _moduleRepository = moduleRepository;
            _moduleGradingRepository = moduleGradingRepository;
        }

        
        //private IList<Module> GetModules(FilterOptions filterOptions)
        //{
        //    IQueryable<Module> modules;

        //    if (!string.IsNullOrWhiteSpace(filterOptions.SearchTerm))
        //    {
        //        modules = _moduleRepository.FindAll(m => m.Name.Contains(filterOptions.SearchTerm));
        //    }
        //    else
        //    {
        //        modules = _moduleRepository.GetAll();
        //    }

        //    switch (filterOptions.Order)
        //    {
        //        case SortOrder.Ascending:
        //            modules = modules.OrderBy(m => m.Name);
        //            break;
        //        case SortOrder.Descending:
        //            modules = modules.OrderByDescending(m => m.Name);
        //            break;
        //    }

        //    return modules.ToList();
        //}
    }
}

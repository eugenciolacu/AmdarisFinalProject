using AmdarisInternship.Domain.Entities;
using System.Collections.Generic;

namespace AmdarisInternship.Infrastructure.Repositories.CustomRepositories
{
    public interface IModuleRepository : IRepository<Module>
    {
        IList<Module> GetModulesWithModuleGradings();
    }
}
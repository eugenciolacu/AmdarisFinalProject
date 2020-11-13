using AmdarisInternship.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisInternship.Infrastructure.Repositories.CustomRepositories
{
    public interface IModuleRepository : IRepository<Module>
    {
        IList<Module> GetModulesWithModuleGradings();

        Module GetModuleWithModuleGradingsByModuleId(int id);
    }
}
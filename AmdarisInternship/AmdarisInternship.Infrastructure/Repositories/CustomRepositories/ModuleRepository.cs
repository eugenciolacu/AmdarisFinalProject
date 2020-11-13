using AmdarisInternship.Domain.Entities;
using AmdarisInternship.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AmdarisInternship.Infrastructure.Repositories.CustomRepositories
{
    public class ModuleRepository : Repository<Module>, IModuleRepository
    {
        public ModuleRepository(AmdarisInternshipContext dbContext) : base(dbContext)
        {

        }

        public IList<Module> GetModulesWithModuleGradings()
        {
            return _dbContext.Modules.Include(x => x.ModuleGradings).ToList();
        }
    }
}

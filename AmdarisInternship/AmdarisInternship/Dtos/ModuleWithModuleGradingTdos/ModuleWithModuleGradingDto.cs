using System.Collections.Generic;

namespace AmdarisInternship.API.Dtos
{
    public class ModuleWithModuleGradingDto
    {
        public ModuleDto Module { get; set; }
        public List<ModuleGradingDto> ModuleGradings { get; set; }

        public ModuleWithModuleGradingDto()
        {
            ModuleGradings = new List<ModuleGradingDto>();
        }
    }
}

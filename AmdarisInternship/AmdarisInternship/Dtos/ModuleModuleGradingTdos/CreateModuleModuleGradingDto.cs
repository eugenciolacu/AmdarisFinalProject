using System.Collections.Generic;

namespace AmdarisInternship.API.Dtos
{
    public class CreateModuleModuleGradingDto
    {
        public CreateModuleDto CreateModuleDto { get; set; }
        public List<CreateModuleGradingDto> CreateModuleGradingDtos { get; set; }
    }
}

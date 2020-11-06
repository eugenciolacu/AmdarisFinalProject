using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AmdarisInternship.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase // Controller
    {
        private readonly IMapper _mapper;
    }
}

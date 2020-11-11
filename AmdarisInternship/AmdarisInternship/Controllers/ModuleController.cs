using AmdarisInternship.API.Dtos;
using AmdarisInternship.API.Exceptions;
using AmdarisInternship.API.Models;
using AmdarisInternship.API.Services;
using AmdarisInternship.API.Services.Interfaces;
using AmdarisInternship.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AmdarisInternship.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : Controller // ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IModuleModuleGradingsService _moduleModuleGradingsService;

        public ModuleController(IModuleModuleGradingsService moduleModuleGradingsService, IMapper mapper)
        {
            _moduleModuleGradingsService = moduleModuleGradingsService;
            _mapper = mapper;
        }

        //[HttpGet]
        //public IActionResult Get()
        //{

        //}

        //[HttpGet]
        //[ApiExceptionFilter]
        //public IActionResult Get([FromQuery] FilterOptions filterOptions)
        //{
        //    IList<Module> modules = _moduleService.GetModules(filterOptions);
        //    IEnumerable<ModuleDto> result = modules.Select(m => _mapper.Map<ModuleDto>(m));

        //    return Ok(result);
        //}

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    Module module = _moduleService.GetModuleById(id);

        //    if (module == null)
        //    {
        //        return NotFound();
        //    }

        //    ModuleDto result = _mapper.Map<ModuleDto>(module);

        //    return Ok(result);
        //}

        [HttpPost]
        public IActionResult Post([FromBody] CreateModuleModuleGradingDto dto)
        {
            var res = _moduleModuleGradingsService.AddNewModuleModuleGradingAsync(dto);

            return Ok();
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] CreateModuleDto dto)
        //{
        //    var module = _moduleService.AddNewModule(dto);

        //    if (module == null)
        //    {
        //        return BadRequest("Module with such Name already exists");
        //    }

        //    var result = _mapper.Map<ModuleDto>(module);

        //    return CreatedAtAction(nameof(Get), new { id = module.Id }, result);
        //}

        //[HttpPut("{id}")]
        //[ApiExceptionFilter]
        //public IActionResult Put(int id, [FromBody] CreateModuleDto dto)
        //{
        //    Module module = _moduleService.UpdateModule(id, dto);

        //    if (module == null)
        //    {
        //        return BadRequest("Module with such Name already exists");
        //    }

        //    return NoContent();
        //}

        //[HttpPatch("{id}")]
        //[ApiExceptionFilter]
        //public IActionResult Patch(int id, [FromBody] UpdateModuleDto dto)
        //{
        //    Module module = _moduleService.UpdateModuleDetails(id, dto);

        //    if (module == null)
        //    {
        //        return NotFound();
        //    }

        //    ModuleDto result = _mapper.Map<ModuleDto>(module);
        //    return Ok(result);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    bool isDeleted = _moduleService.RemoveModuleById(id);

        //    return NoContent();
        //}
    }
}

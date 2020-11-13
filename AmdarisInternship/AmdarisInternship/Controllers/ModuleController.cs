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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok (_moduleModuleGradingsService.GetModulesWithModuleGradings());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_moduleModuleGradingsService.GetModuleWithModuleGradingsByModuleId(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ModuleWithModuleGradingDto dto)
        {
            var moduleWithGrading = _moduleModuleGradingsService.AddNewModuleWithModuleGrading(dto);

            return CreatedAtAction(nameof(Get), new { id = moduleWithGrading.Module.Id }, moduleWithGrading);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ModuleWithModuleGradingDto dto)
        {
            var moduleWithGrading = _moduleModuleGradingsService.UpdateModuleWithModuleGrading(id, dto);

            return CreatedAtAction(nameof(Get), new { id = moduleWithGrading.Module.Id }, moduleWithGrading);
        }

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

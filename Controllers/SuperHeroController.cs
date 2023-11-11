using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net7_WebAPI_Entity.Models;
using Net7_WebAPI_Entity.Services.SuperHeroService;

namespace Net7_WebAPI_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        private readonly ILogger<SuperHeroController> _logger;
       
        public SuperHeroController(ISuperHeroService superHeroService,ILogger<SuperHeroController> logger)
        {
            _superHeroService = superHeroService;
            _logger = logger;
        }
        // GET: api/SuperHero
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            
            var result = await _superHeroService.GetAllHeroes();
            _logger.LogInformation("GetAllHeroes called");
            return Ok(result);

        }
        // GET: api/SuperHero/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroById(int id)
        {
           
            var result = await _superHeroService.GetHeroById(id);
            if (result is null)
            {
                return NotFound("Hero not found");
            }
            _logger.LogInformation("GetHeroById called");
            return Ok(result);
        }
        // POST: api/SuperHero
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = await _superHeroService.AddHero(hero);
            return Ok(result);
        }
        // PUT: api/SuperHero/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero hero)
        {
            var result = await _superHeroService.UpdateHero(id, hero);
            if (result is null)
            {
                return NotFound("Hero not found");
            }
            return Ok(result);
        }
        // DELETE: api/SuperHero/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
           var result = await _superHeroService.DeleteHero(id);
              if (result is null)
              {
                return NotFound("Hero not found");
              }

              return Ok(result);
        }
    }
}

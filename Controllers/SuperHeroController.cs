using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net7_WebAPI_Entity.Models;

namespace Net7_WebAPI_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Batman",
                LastName = "Wayne",
                SecretIdentity = "Bruce Wayne",
                PlaceOfBirth = "Gotham City",
                Occupation = "CEO of Wayne Enterprises",
                PlaceOfResidence = "Gotham City"
            },
            new SuperHero
            {
                Id = 2,
                Name = "Superman",
                LastName = "Kent",
                SecretIdentity = "Clark Kent",
                PlaceOfBirth = "Krypton",
                Occupation = "Reporter",
                PlaceOfResidence = "Metropolis"
            },
            new SuperHero
            {
                Id = 3,
                Name = "Iron Man",
                LastName = "Stark",
                SecretIdentity = "Tony Stark",
                PlaceOfBirth = "Long Island",
                Occupation = "CEO of Stark Industries",
                PlaceOfResidence = "New York City"
            }
        };
        // GET: api/SuperHero
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            
            return Ok(superHeroes);

        }
        // GET: api/SuperHero/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroById(int id)
        {
           
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return NotFound("Hero not found");
            }
            return Ok(hero);
        }
        // POST: api/SuperHero
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return Ok(superHeroes);
        }
        // PUT: api/SuperHero/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateHero(int id, SuperHero hero)
        {
            var heroToUpdate = superHeroes.Find(x => x.Id == id);
            if (heroToUpdate == null)
            {
                return NotFound("Hero not found");
            }
            heroToUpdate.Name = hero.Name;
            heroToUpdate.LastName = hero.LastName;
            heroToUpdate.SecretIdentity = hero.SecretIdentity;
            heroToUpdate.PlaceOfBirth = hero.PlaceOfBirth;
            heroToUpdate.Occupation = hero.Occupation;
            heroToUpdate.PlaceOfResidence = hero.PlaceOfResidence;
            return Ok(superHeroes);
        }
        // DELETE: api/SuperHero/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> DeleteHero(int id)
        {
            var heroToDelete = superHeroes.Find(x => x.Id == id);
            if (heroToDelete == null)
            {
                return NotFound("Hero not found");
            }
            superHeroes.Remove(heroToDelete);
            return Ok(superHeroes);
        }
    }
}


namespace Net7_WebAPI_Entity.Services.SuperHeroService;

public interface ISuperHeroService
{
    List<SuperHero> GetAllHeroes();
    SuperHero GetHeroById(int id);
    List<SuperHero>? AddHero(SuperHero hero);
    List<SuperHero>? UpdateHero(int id, SuperHero hero);
    List<SuperHero>? DeleteHero(int id); 
}
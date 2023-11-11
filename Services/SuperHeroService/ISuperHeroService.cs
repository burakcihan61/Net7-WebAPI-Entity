namespace Net7_WebAPI_Entity.Services.SuperHeroService;

public interface ISuperHeroService
{
    Task<List<SuperHero>> GetAllHeroes();
    Task<SuperHero?> GetHeroById(int id);
    Task<List<SuperHero>?> AddHero(SuperHero hero);
    Task<List<SuperHero>?> UpdateHero(int id, SuperHero hero);
    Task<List<SuperHero>?> DeleteHero(int id);
}

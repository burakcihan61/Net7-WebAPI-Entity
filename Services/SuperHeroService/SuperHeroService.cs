namespace Net7_WebAPI_Entity.Services.SuperHeroService;

public class SuperHeroService : ISuperHeroService
{
    private readonly DataContext _context;
    public SuperHeroService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<SuperHero>> GetAllHeroes()
    {
        var heroes = await _context.SuperHeroes.ToListAsync();
        return heroes;
    }

    public async Task<SuperHero?> GetHeroById(int id)
    {
        var hero = await _context.SuperHeroes.FindAsync(id);
        if (hero == null)
        {
            return null;
        }
        return hero;
    }

    public async Task<List<SuperHero>?> AddHero(SuperHero hero)
    {
        await _context.SuperHeroes.AddAsync(hero);
        await _context.SaveChangesAsync();
        return await _context.SuperHeroes.ToListAsync();
    }

    public async Task<List<SuperHero>?> UpdateHero(int id, SuperHero hero)
    {
        var heroToUpdate = await _context.SuperHeroes.FindAsync(id);
        if (heroToUpdate == null)
        {
            return null;
        }
        heroToUpdate.Name = hero.Name;
        heroToUpdate.LastName = hero.LastName;
        heroToUpdate.SecretIdentity = hero.SecretIdentity;
        heroToUpdate.PlaceOfBirth = hero.PlaceOfBirth;
        heroToUpdate.Occupation = hero.Occupation;
        heroToUpdate.PlaceOfResidence = hero.PlaceOfResidence;
        await _context.SaveChangesAsync();
        return _context.SuperHeroes.ToList();
    }

    public async Task<List<SuperHero>?> DeleteHero(int id)
    {
        var heroToDelete = await _context.SuperHeroes.FindAsync(id);
        if (heroToDelete == null)
        {
            return null;
        }
        _context.SuperHeroes.Remove(heroToDelete);
        await _context.SaveChangesAsync();
        return await _context.SuperHeroes.ToListAsync();
    }
}
namespace Net7_WebAPI_Entity.Services.SuperHeroService;

public class SuperHeroService : ISuperHeroService
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
    public List<SuperHero> GetAllHeroes()
    {
        return superHeroes;
    }

    public SuperHero GetHeroById(int id)
    {
        var hero = superHeroes.Find(x => x.Id == id);
        if (hero == null)
        {
            return null;
        }
        return hero;
    }

    public List<SuperHero> AddHero(SuperHero hero)
    {
        superHeroes.Add(hero);
        return superHeroes;
    }

    public List<SuperHero> UpdateHero(int id, SuperHero hero)
    {
        var heroToUpdate = superHeroes.Find(x => x.Id == id);
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
        return superHeroes;
    }

    public List<SuperHero> DeleteHero(int id)
    {
        var heroToDelete = superHeroes.Find(x => x.Id == id);
        if (heroToDelete == null)
        {
            return null;
        }
        superHeroes.Remove(heroToDelete);
        return superHeroes;
    }
}
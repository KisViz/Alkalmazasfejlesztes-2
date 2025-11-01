using Heroes.Model;

namespace Heroes.DAO
{
    public interface IHeroesDao
    {
        bool AddHero(Hero hero);
        bool ModifyHero(Hero hero);
        IEnumerable<Hero> GetHeroes();
        Hero GetHero(int heroId);
    }
}

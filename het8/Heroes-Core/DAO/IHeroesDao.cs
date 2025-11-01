using Heroes_Core.Model;

namespace Heroes_Core.DAO
{
    public interface IHeroesDao
    {
        bool AddHero(Hero hero);
        bool ModifyHero (Hero hero);
        IEnumerable<Hero> GetHeroes();
        Hero GetHero (int heroId);
        int HeroesCount();
    }
}

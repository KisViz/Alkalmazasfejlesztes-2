
using het6.model;

namespace Heroes.DAO
{
    public interface IHeroesDao
    {
        bool AddHero(Hero hero);
        bool ModifyHero(Hero hero);

        int HeroesCount();
        Hero GetHero(int heroId);
        IEnumerable<Hero> GetHeroes();
    }
}



using Heroes.DAO;
using het6.model;

namespace het6.dao
{
    internal class HeroesMemoryDao : IHeroesDao
    {
        bool IHeroesDao.AddHero(Hero hero)
        {
            throw new NotImplementedException();
        }

        Hero IHeroesDao.GetHero(int heroId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Hero> IHeroesDao.GetHeroes()
        {
            throw new NotImplementedException();
        }

        int IHeroesDao.HeroesCount()
        {
            throw new NotImplementedException();
        }

        bool IHeroesDao.ModifyHero(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}

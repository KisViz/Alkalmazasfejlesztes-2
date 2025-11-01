

using Heroes.DAO;
using het6.model;

namespace het6.controller
{
    public class HeroesController
    {
        private readonly IHeroesDao dao;
        public HeroesController(IHeroesDao heroesDao)
        {
            dao = heroesDao;
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return dao.GetHeroes();
        }

        // ...
        public bool ModifyHero(Hero hero)
        {
            return dao.ModifyHero(hero);
        }
    }

}

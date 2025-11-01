using Heroes_Core.DAO;
using Heroes_Core.Model;

namespace Heroes_Core.Controller
{
    public class HeroesController
    {
        private readonly IHeroesDao dao;

        public HeroesController(IHeroesDao dao)
        {
            this.dao = dao;
        }

        public bool AddHero(Hero hero)
        {
            int id = dao.HeroesCount();
            hero.ID = id;

            return dao.AddHero(hero);
        }

        public bool ModifyHero(Hero hero) 
        {
            return dao.ModifyHero(hero);
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return dao.GetHeroes();
        }

        public Hero GetHero(int id) 
        {
            return dao.GetHero(id);
        }

    }
}
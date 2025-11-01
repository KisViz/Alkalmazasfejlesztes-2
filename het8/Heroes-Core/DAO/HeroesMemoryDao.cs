using Heroes_Core.Model;

namespace Heroes_Core.DAO
{
    public class HeroesMemoryDao : IHeroesDao
    {
        private IList<Hero> heroes = new List<Hero>();

        public bool AddHero(Hero hero)
        {
            if (hero == null)
            {
                return false;
            }
            if (heroes.Any(x=> x.HeroName == hero.HeroName ))
            {
                return false;
            }

            heroes.Add(hero);
            return true;
        }

        public Hero GetHero(int heroId)
        {
            return heroes.FirstOrDefault(x => x.ID == heroId);
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return heroes;
        }

        public int HeroesCount()
        {
            return heroes.Count();
        }

        public bool ModifyHero(Hero hero)
        {
            int storedIndex = heroes.IndexOf(heroes.FirstOrDefault(x => x.ID == hero.ID));

            if (storedIndex == -1) 
            { 
                return false;
            }

            heroes[storedIndex] = hero;
            return true;

        }
    }
}

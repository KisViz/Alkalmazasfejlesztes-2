using Heroes.Model;

namespace Heroes.DAO
{
    public class MemoryDao : IHeroesDao
    {
        private IList<Hero> heroes = new List<Hero>();

        public bool AddHero(Hero hero)
        {
            if (hero == null)
                return false;

            if (heroes.Any(x => x.HeroName == hero.HeroName))
                return false;

            heroes.Add(hero);
            return true;
        }

        public int HeroesCount()
        {
            return heroes.Count();
        }

        public bool ModifyHero(Hero hero)
        {
            int storedIndex = heroes.IndexOf(heroes.FirstOrDefault(x => x.ID == hero.ID));

            if (storedIndex == -1)
                return false;

            heroes[storedIndex] = hero;
            return true;
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return heroes;
        }

        public Hero GetHero(int heroId)
        {
            return heroes.FirstOrDefault(x => x.ID == heroId);
        }
    }
}

using Heroes.Model;
using System.Data.SQLite;

namespace Heroes.DAO
{
    public class HeroesAdoDao : IHeroesDao
    {
        private const string CONN_STRING = @"Data Source=..\..\..\Database\heroes.db;";
        public bool AddHero(Hero hero)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            //insert into valami (oszlop 1, ... ) values (1, 2, 3, 4, ... )
            command.CommandText = "insert into hero "
                + "(name, hero_name, hero_power, age) values "
                + "(@name, @heroname, @power, @age);";

            command.Parameters.Add("name", System.Data.DbType.String).Value = hero.Name;
            command.Parameters.Add("heroname", System.Data.DbType.String).Value = hero.HeroName;
            command.Parameters.Add("power", System.Data.DbType.String).Value = hero.Power;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = hero.Age;

            bool ret = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = false;
            }

            connection.Close();
            return ret;
        }

        public Hero GetHero(int heroId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hero> GetHeroes()
        {
            List<Hero> heroes = new List<Hero>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "select * from hero"; //a get heronal: where id = @id

            using var reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                //reader.GetOrdinal("oszlop neve")
                heroes.Add(new Hero
                {
                    ID = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                    HeroName = reader.GetString(reader.GetOrdinal("hero_name")),
                    Power = reader.GetString(reader.GetOrdinal("hero_power")),
                    Age = reader.GetInt32(reader.GetOrdinal("age"))
                });
            }

            connection.Close();
            return heroes;
        }

        public bool ModifyHero(Hero hero)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            //update hero SET ... where ... id = @id
            command.CommandText = "update hero set "
                + "name=@name, hero_name=@hero_name, hero_power=hero_power, age=age "
                + "where id=@id;";

            command.Parameters.Add("name", System.Data.DbType.String).Value = hero.Name;
            command.Parameters.Add("hero_name", System.Data.DbType.String).Value = hero.HeroName;
            command.Parameters.Add("hero_power", System.Data.DbType.String).Value = hero.Power;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = hero.Age;
            command.Parameters.Add("id", System.Data.DbType.Int32).Value = hero.ID;

            bool ret = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = false;
            }

            connection.Close();
            return ret;
        }
    }
}

using mintaZh.Model;
using System.Data.SQLite;

namespace mintaZh.DAO
{
    public class EgyedDao : IEgyedDao
    {
        private const string CONN_STRING = @"Data Source=..\..\..\Database\vadrezervatum.kedd12db.kedd10db;";
        public bool AddEged(Egyed egyed)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            //insert into valami (oszlop 1, ... ) values (1, 2, 3, 4, ... )
            command.CommandText = "insert into magashegyi_VadRezervatum "
                + "(species, age, weight, gender, name) values "
                + "(@species, @age, @weight, @gender, @name);";

            command.Parameters.Add("species", System.Data.DbType.String).Value = egyed.Species;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = egyed.Age;
            command.Parameters.Add("weight", System.Data.DbType.Decimal).Value = egyed.Weigh;
            command.Parameters.Add("gender", System.Data.DbType.String).Value = egyed.Gender;
            command.Parameters.Add("name", System.Data.DbType.String).Value = egyed.Name;

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

        public IEnumerable<Egyed> GetEgyeds()
        {
            List<Egyed> egyeds = new List<Egyed>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "select * from magashegyi_VadRezervatum;"; //a get heronal: where id = @id

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                //reader.GetOrdinal("oszlop neve")
                egyeds.Add(new Egyed
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Species = reader.GetString(reader.GetOrdinal("species")),
                    Age = reader.GetInt32(reader.GetOrdinal("age")),
                    Weigh = reader.GetDecimal(reader.GetOrdinal("weight")),
                    Gender = reader.GetString(reader.GetOrdinal("gender")),
                    Name = reader.GetString(reader.GetOrdinal("name"))
                });
            }

            connection.Close();
            return egyeds;
        }

        public bool ModifyEgyed(Egyed egyed)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            //update hero SET ... where ... id = @id
            command.CommandText = "update magashegyi_VadRezervatum set "
                + "species=@species, age=@age, weight=@weight, gender=@gender, name=@name "
                + "where id=@id;";

            command.Parameters.Add("species", System.Data.DbType.String).Value = egyed.Species;
            command.Parameters.Add("age", System.Data.DbType.Int32).Value = egyed.Age;
            command.Parameters.Add("weight", System.Data.DbType.Decimal).Value = egyed.Weigh;
            command.Parameters.Add("gender", System.Data.DbType.String).Value = egyed.Gender;
            command.Parameters.Add("name", System.Data.DbType.String).Value = egyed.Name;
            command.Parameters.Add("id", System.Data.DbType.Int32).Value = egyed.Id;

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







        public decimal? GetAverageWeightBySpeciesAndGender(string species, string gender)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT AVG(weight) FROM magashegyi_VadRezervatum WHERE species=@species AND gender=@gender;";
            command.Parameters.AddWithValue("@species", species);
            command.Parameters.AddWithValue("@gender", gender);

            object result = command.ExecuteScalar();
            connection.Close();

            if (result == DBNull.Value || result == null)
                return null;

            return Convert.ToDecimal(result);
        }
    }
}

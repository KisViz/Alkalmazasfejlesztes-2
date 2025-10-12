using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using het11.model;

namespace het11
{
    internal class Program
    {

        private static IEnumerable<T> LoadData<T>(string path)
        {
            var data = new List<T>();

            if (!File.Exists(path))
            {
                Console.WriteLine("nem letezo file");
                Environment.Exit(1);
            }

            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = System.Text.Encoding.UTF8,
                Delimiter = ",",
                BadDataFound = (context) => { },
                MissingFieldFound = (context) => { },
            };

            using var reader = new StreamReader(path);
            using var csvReader = new CsvReader(reader, configuration);
            csvReader.Read();
            csvReader.ReadHeader();

            while (csvReader.Read())
            {
                T record = csvReader.GetRecord<T>();
                data.Add(record);
            }


            return data;
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("probald beallitani 2 db csv utvonalat");
                Environment.Exit(1);
            }

            var athletes = LoadData<Athletee>(args[0]);
            var countries = LoadData<Countryy>(args[1]);


            //            3.LINQ segítségével határozd meg az összes sportoló átlagéletkorát.
            //Elvárt eredmény: szám(2 tizedesjegyre kerekítve)

            double avgAge = athletes.Average(x => x.Age);
            Console.WriteLine("3. feladat");
            Console.WriteLine($"\t{avgAge:N2}");


            //            4.LINQ segítségével keresd meg, majd kistázd ki a legmagasabb sportoló nevét és magasságát.
            //Elvárt eredmény: "név: magasság cm", pl. "John Doe: 200 cm"
            Athletee highestAthlete = athletes
                .OrderByDescending(x => x.Height)
                .First();
            Console.WriteLine("4. feladat");
            Console.WriteLine($"\t{highestAthlete.Name} : {highestAthlete.Height} cm");


            //            5.LINQ segítségével számold meg, hogy csapatonként hány sportoló szerepel az adathalmazban.
            //Elvárt eredmény: "csapat név: számosság" egymás után kiírva a számmosság alapján csökkenő
            //sorrendben, pl. "Hungary: 12"
            //Fontos: Ne a csapat rövidítését írd ki, hanem a teljes nevét(HUN →Hungary).
            var athletesWithNames = athletes
                .Join(countries,
                athlete => athlete.Nationality,
                country => country.Abbreviation,
                (ath, cou) => new Athletee
                {
                    ID = ath.ID,
                    Name = ath.Name,
                    Sex = ath.Sex,
                    Height = ath.Height,
                    Weight = ath.Weight,
                    Nationality = cou.Name

                });
            var athletesPerCountry = athletesWithNames
                .GroupBy(x => x.Nationality)
                .Select(group => new
                {
                    Countryy = group.Key,
                    Count = group.Count(),
                }).OrderByDescending(x => x.Count);
            Console.WriteLine("5. feladat");
            foreach (var item in athletesPerCountry)
            {
                Console.WriteLine($"{item.Countryy}: {item.Count}");
            }


            //            6.LINQ segítségével határozd meg a női sportolók átlagmagasságát.
            //Elvárt eredmény: "Női sportolók átlagmagassága: X cm (2 tizedesjegyre kerekítve)"
            double avgWomenHheigh = athletesWithNames
                .Where(x => x.Sex == "F")
                .Average(x => x.Height);
            Console.WriteLine("6. feladat");
            Console.WriteLine($"\tNői sportolók átlagmagassága: {avgWomenHheigh:N2} cm");


            //            7.LINQ segítségével keresd meg, majd listázd ki azoknak a sportolóknak a nevét ABC sorrendben,
            //akik 25 év alattiak.
            //Elvárt eredmény: "Név" egymás után kiírva a megfelelő sorrendben.
            var xoungAthletes = athletesWithNames
                .OrderBy(x => x.Name)
                .Where(x => x.Age < 25)
                .Select(x => x.Name);
            Console.WriteLine("7. feladat");
            foreach (var item in xoungAthletes)
            {
                Console.WriteLine($"{item}");
            }


            //            8.LINQ segítségével minden csapatból keresd meg a legnehezebb sportolót. A kiíratás a legnehezebb
            //sportolótól induljon a legkönnyebb felé.
            //Elvárt eredmény: "csapat teljes neve: sportoló neve (tömeg kg)" egymás után kiírva a megfelelő
            //sorrendben.
            var heaviestAthletes = athletesWithNames
                .GroupBy(group => group.Nationality)
                .Select(group => new
                {
                    Countryy = group.Key,
                    Athletee = group
                    .OrderByDescending(group => group.Weight)
                    .First(),
                }).OrderByDescending (x => x.Athletee.Weight);
            Console.WriteLine("8. feladat");
            foreach (var item in heaviestAthletes)
            {
                Console.WriteLine($"{item.Countryy}: {item.Athletee.Name} ({item.Athletee.Weight} kg)");
            }


            //            9.LINQ segítségével csoportosítsd a sportolókat nem szerint, és számítsd ki mindkét csoport átlagéletkorát.
            //Elvárt eredmény: "nem: átlagéletkor (2 tizedesjegyre kerekítve)" egymás után kiírva.
            var avgAgePerSex = athletes
                .GroupBy(x => x.Sex)
                .Select(group => new
                {
                    Name = group.Key,
                    AverageAGe = group.Average(x => x.Age)
                });
            Console.WriteLine("9. feladat");
            foreach (var item in avgAgePerSex)
            {
                Console.WriteLine($"{item.Name}: {item.AverageAGe:N2}");
            }

        }
    }
}
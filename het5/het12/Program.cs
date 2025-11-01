using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using het12.model;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace het12
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
                Console.WriteLine("Adj meg ket utvonalat!");
                Environment.Exit(1);
            }

            var athletes = LoadData<Athlete>(args[0]);
            var countries = LoadData<Country>(args[1]);

            //foreach (var item in athletes)
            //{
            //    Console.WriteLine($"{item.Age}");
            //}


            //            LINQ segítségével határozd meg az összes sportoló átlagéletkorát.
            //Elvárt eredmény: szám(2 tizedesjegyre kerekítve)
            double avgAge = athletes.Average(x => x.Age);
            Console.WriteLine("3. feladat");
            Console.WriteLine($"\t{avgAge:N2}");


            //            4.LINQ segítségével keresd meg, majd kistázd ki a legmagasabb sportoló nevét és magasságát.
            //Elvárt eredmény: "név: magasság cm", pl. "John Doe: 200 cm"
            Athlete highestAthlete = athletes
                .OrderByDescending(x =>x.Height)
                .First();
            Console.WriteLine("4. feladat");
            Console.WriteLine($"\t{highestAthlete.Name}: {highestAthlete.Height} cm");


            //            5.LINQ segítségével számold meg, hogy csapatonként hány sportoló szerepel az adathalmazban.
            //Elvárt eredmény: "csapat név: számosság" egymás után kiírva a számmosság alapján csökkenő
            //sorrendben, pl. "Hungary: 12"
            //Fontos: Ne a csapat rövidítését írd ki, hanem a teljes nevét(HUN →Hungary).
            var athletesWithNames =
                from athlete in athletes
                join country in countries
                on athlete.Nationality equals country.Abbreviation
                select new Athlete
                {
                    ID = athlete.ID,
                    Name = athlete.Name,
                    Sex = athlete.Sex,
                    Height = athlete.Height,
                    Weight = athlete.Weight,
                    Nationality = country.Name
                };

            var athletesPerTeam = athletesWithNames
                .GroupBy(x => x.Nationality)
                .Select(group => new
                {
                    Country = group.Key,
                    Count = group.Count(),
                }).OrderByDescending(x => x.Count);
            Console.WriteLine("5. feladat");
            foreach (var item in athletesPerTeam)
            {
            Console.WriteLine($"\t{item.Country}: {item.Count}");
            }


            //            6.LINQ segítségével határozd meg a női sportolók átlagmagasságát.
            //Elvárt eredmény: "Női sportolók átlagmagassága: X cm (2 tizedesjegyre kerekítve)".
            double avgWomenHeight = athletesWithNames
                .Where(x => x.Sex == "F")
                .Select(x => x.Height)
                .Average();
            Console.WriteLine("6. feladat");
            Console.WriteLine($"\tNői sportolók átlagmagassága: {avgWomenHeight:N2} cm (2 tizedesjegyre kerekítve)\"");


            //            7.LINQ segítségével keresd meg, majd listázd ki azoknak a sportolóknak a nevét ABC sorrendben,
            //akik 25 év alattiak.
            //Elvárt eredmény: "Név" egymás után kiírva a megfelelő sorrendben.
            var youngAthletes = athletesWithNames
                .Where(x => x.Age < 25)
                .OrderBy(x => x.Name);
            Console.WriteLine("7. feladat");
            foreach (var item in youngAthletes)
            {
                Console.WriteLine($"\t{item.Name}");
            }


            //            8.LINQ segítségével minden csapatból keresd meg a legnehezebb sportolót. A kiíratás a legnehezebb
            //sportolótól induljon a legkönnyebb felé.
            //Elvárt eredmény: "csapat teljes neve: sportoló neve (tömeg kg)" egymás után kiírva a megfelelő
            //sorrendben.
            var heaviestAthletes = athletesWithNames
                .GroupBy(x => x.Nationality)
                .Select(group => new
                {
                    Country = group.Key,
                    Athlete = group
                    .OrderByDescending(x => x.Weight)
                    .First()

                }).OrderByDescending(x => x.Athlete.Weight);
            Console.WriteLine("8. feladat");
            foreach (var item in heaviestAthletes)
            {
                Console.WriteLine($"\t{item.Country}: {item.Athlete.Name} ({item.Athlete.Weight})");
            }


            //            9.LINQ segítségével csoportosítsd a sportolókat nem szerint, és számítsd ki mindkét csoport átlagéletkorát.
            //Elvárt eredmény: "nem: átlagéletkor (2 tizedesjegyre kerekítve)" egymás után kiírva
            var avgAgePerSex = athletes
                .GroupBy(x => x.Sex)
                .Select(group => new
                {
                    Name = group.Key,
                    Age = group.Average(x => x.Age)
                });
            Console.WriteLine("9. feladat");
            foreach (var item in avgAgePerSex)
            {
                Console.WriteLine($"\t{item.Name}: {item.Age:N2}");
            }
        }
    }
}

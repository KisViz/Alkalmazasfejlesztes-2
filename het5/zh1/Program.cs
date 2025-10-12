using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using zh1.model;

namespace zh1
{
    internal class Program
    {
        private static IEnumerable<T> LoadData<T>(string path)
        {
            if (!File.Exists(path)) 
            {
                Console.WriteLine($"Hiba a megadott file nem letezik {path}!");
                Environment.Exit(1);
            }

            var configuration = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
            {
                Encoding = System.Text.Encoding.UTF8,
                Delimiter = ",",
                BadDataFound = (args) => { },
                MissingFieldFound = (args) => { },
            };

            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, configuration);

            return csv.GetRecords<T>().ToList();
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Hiba pontosan ket csvt adj meg!");
                Environment.Exit(1);
            }

            var athletes = LoadData<Athlete>(args[0]);
            var countries = LoadData<Country>(args[1]);


            //            3.LINQ segítségével határozd meg az összes sportoló átlagéletkorát.
            //Elvárt eredmény: szám(2 tizedesjegyre kerekítve)
            double avgAge = athletes.Average(x => x.Age);
            Console.WriteLine("3. feladat");
            Console.WriteLine($"\t{avgAge:N2}");


            //            4.LINQ segítségével keresd meg, majd kistázd ki a legmagasabb sportoló nevét és magasságát.
            //Elvárt eredmény: "név: magasság cm", pl. "John Doe: 200 cm"
            Athlete highestAthlete = athletes
                .OrderByDescending(x => x.Height).First();
            Console.WriteLine("4. feladat");
            Console.WriteLine($"\t{highestAthlete.Name}: {highestAthlete.Height}");


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
                    Age = athlete.Age,
                    Height = athlete.Height,
                    Weight = athlete.Weight,
                    Nationality = country.Name
                };
            var athletesPerTeam = athletesWithNames
                .GroupBy(x => x.Nationality)
                .Select(group => new
                {
                    Name = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count);
            Console.WriteLine("5. feladat");
            foreach(var item in athletesPerTeam)
            {
                Console.WriteLine($"\t{item.Name}: {item.Count}");
            }


            //            6.LINQ segítségével határozd meg a női sportolók átlagmagasságát.
            //Elvárt eredmény: "Női sportolók átlagmagassága: X cm (2 tizedesjegyre kerekítve)"
            double avgHeightWomen = athletesWithNames
                .Where(x => x.Sex == "F")
                .Average(x => x.Height);
            Console.WriteLine("6. feladat");
            Console.WriteLine($"\tNői sportolók átlagmagassága: {avgHeightWomen:N2} cm.");


            //            7.LINQ segítségével keresd meg, majd listázd ki azoknak a sportolóknak a nevét ABC sorrendben,
            //akik 25 év alattiak.
            //Elvárt eredmény: "Név" egymás után kiírva a megfelelő sorrendben.
            var youngNames = athletesWithNames
                .Where(x => x.Age < 25)
                .OrderBy(x => x.Name)
                .Select(x => x.Name);
            Console.WriteLine("7. feladat");
            foreach (var item in youngNames)
            {
                Console.WriteLine($"\t{item}");
            }


            //            8.LINQ segítségével minden csapatból keresd meg a legnehezebb sportolót. A kiíratás a legnehezebb
            //sportolótól induljon a legkönnyebb felé.
            //Elvárt eredmény: "csapat teljes neve: sportoló neve (tömeg kg)" egymás után kiírva a megfelelő
            //sorrendben.
            var heaiestAthletes = athletesWithNames
                .GroupBy(x => x.Nationality)
                .Select(group => new
                {
                    Name = group.Key,
                    Athlete = group.OrderByDescending(x => x.Weight).First()
                })
                .OrderByDescending(x => x.Athlete.Weight);
            Console.WriteLine("8. feladat");
            foreach (var item in heaiestAthletes)
            {
                Console.WriteLine($"\t{item.Name}: {item.Athlete.Name} ({item.Athlete.Weight} kg)");
            }


            //            9.LINQ segítségével csoportosítsd a sportolókat nem szerint, és számítsd ki mindkét csoport átlagéletkorát.
            //Elvárt eredmény: "nem: átlagéletkor (2 tizedesjegyre kerekítve)" egymás után kiírva.
            var avgAge2 = athletesWithNames
                .GroupBy(x => x.Sex)
                .Select(group => new
                {
                    Name = group.Key,
                    AvgAge = group.Average(x => x.Age),
                });

            Console.WriteLine("9. feladat");
            foreach (var item in avgAge2)
            {
                Console.WriteLine($"\t{item.Name}: {item.AvgAge:N2}");
            }
        }
    }
}

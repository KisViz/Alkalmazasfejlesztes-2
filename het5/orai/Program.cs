using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using het4.model;

namespace het4
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

            var athletes = LoadData<Athletes>(args[0]);
            var countries = LoadData<Countries>(args[1]);

            double avgAge = athletes.Average(x => x.Age);
            Console.WriteLine("3. feladat");
            Console.WriteLine($"\t{avgAge:N2}");


            Athletes highestAtlete = athletes.OrderByDescending(x => x.Height).First();
            Console.WriteLine("4. feladat");
            Console.WriteLine($"\t{highestAtlete.Name}: {highestAtlete.Height} cm");


            var athletesWithNames =
                from athlete in athletes
                join country in countries
                on athlete.Nationality equals country.Abbreviation
                select new Athletes
                {
                    ID = athlete.ID,
                    Name = athlete.Name,
                    Sex = athlete.Sex,
                    Height = athlete.Height,
                    Weight = athlete.Weight,
                    Nationality = country.Name
                };

            var athletesPerCountry = athletesWithNames.GroupBy
                (x => x.Nationality).Select(group => new
                {
                    Country = group.Key,
                    Count = group.Count()
                }).OrderByDescending(x => x.Count);

            Console.WriteLine("5. feladat");
            foreach (var athlete in athletesPerCountry)
            {
            Console.WriteLine($"\t{athlete.Country}: {athlete.Count}");

            }


            double womenAvgHeight = athletesWithNames.Where(x => x.Sex == "F").Average(x => x.Height);
            Console.WriteLine("6. feladat");
            Console.WriteLine($"\tnoi sportolok atlag magassaga {womenAvgHeight} cm");


            var youngAthletes = athletesWithNames.Where(x => x.Age < 25).OrderBy(x => x.Name);
            Console.WriteLine("7. feladat");
            foreach (var athlete in youngAthletes)
            {
                Console.WriteLine($"\t{athlete.Name}");
            }


            var heavyesstAteletes = athletesWithNames.GroupBy
               (x => x.Nationality).Select(group => new
               {
                   Country = group.Key,
                   Athlete = group.OrderByDescending(x => x.Weight).First()
               }).OrderByDescending(x => x.Athlete.Weight);
            Console.WriteLine("8. feladat");
            foreach (var athlete in heavyesstAteletes)
            {
                Console.WriteLine($"\t{athlete.Country}: {athlete.Athlete.Name} ({athlete.Athlete.Weight} kg)");
            }


            var asd = athletes
                .GroupBy(x => x.Sex)
                .Select(group => new
                {
                    Name = group.Key,
                    AverageAge = group.Average(x => x.Age)
                });
            Console.WriteLine("9. feladat");
            foreach (var athlete in asd)
            {
                Console.WriteLine($"\t{athlete.Name}: {athlete.AverageAge}");
            }
        }
    }
}

using Serilog;
using System;

//namespace het1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string stg = Console.ReadLine();
//            Console.WriteLine($"Your answer: {stg}");
//        }
//    }
//}


namespace NuGet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .CreateLogger();

            log.Debug("Hello World");
            log.Information("Hello World");
        }
    }
}

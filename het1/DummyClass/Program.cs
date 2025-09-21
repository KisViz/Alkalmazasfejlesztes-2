namespace het11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Írjon be egy számot: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int res))
                {
                    Console.WriteLine();

                    var magician = new DummyClass(res);

                    Console.Write("A kapott számból előálló mágikus szám: ");
                    Console.WriteLine(magician.CalculateMagicNumber());
                }
                else
                {
                    Console.WriteLine("Rossz input, csak egész számot vár a program.");
                }


            }
        }
    }
}

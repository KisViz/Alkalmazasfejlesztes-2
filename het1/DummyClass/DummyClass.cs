namespace het11
{
    class DummyClass
    {
        private int userInput;

        public DummyClass(int userInput)
        {
            this.userInput = userInput;
        }

        public double CalculateMagicNumber()
        {
            try
            {
                return 1024 / (userInput - 42);
            }
            catch (Exception)
            {
                Console.WriteLine("Nem támogatott mágikus szám.");
                return 0;
            }
        }
    }
}

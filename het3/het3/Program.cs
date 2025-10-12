// See https://aka.ms/new-console-template for more information


using System.Collections;

class Program
{

    public static int[] Func(int start, int number)
    {
        int[] _number = new int[number];
        for (int i = 0; i < number; i++)
            _number[i] = start + 2 * i;

        return _number;
    }


    public static IEnumerable Func2(int start, int number)
    {
        for (int i = 0; i < number; i++)
        {
            yield return start + 2 * i;
        }
    }



    static void Main(string[] args)
    {
        //List<string> someList = new List<string>();
        //someList.Add("alma");
        //someList.Add("korte");

        //foreach (var item in someList)
        //{
        //    Console.WriteLine(item);
        //}

        //foreach (var item in Func(2, 10))
        //{
        //    Console.WriteLine(item);
        //}

        //foreach (var item in Func2(2, 10))
        //{
        //    Console.WriteLine(item);
        //}

        double szam = 6.76;
        //Console.WriteLine(szam is int);

        int? szam2 = szam as int?;
        Console.WriteLine(szam2);


    }
}
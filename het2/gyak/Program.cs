using System.Threading.Tasks;

while (true)
{
    string input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }

    string[] darabok = input.Split(" ");

    //Console.WriteLine($"{darabok[0]}, {darabok[1]}, {darabok[2]}");

    string[] operants = ["+", "-", "*", "/"];

    try
    {
        if (operants.Contains(darabok[0]) &&
            int.TryParse(darabok[1], out int elso) &&
            int.TryParse(darabok[2], out int masodik))
        {
            if (darabok[0] == "+")
            {
                Console.WriteLine("eredmeny: " + (elso + masodik));
            }
            if (darabok[0] == "-")
            {
                Console.WriteLine("eredmeny: " + (elso - masodik));
            }
            if (darabok[0] == "*")
            {
                Console.WriteLine("eredmeny: " + (elso * masodik));
            }
            if (darabok[0] == "/")
            {
                Console.WriteLine("eredmeny: " + (elso / masodik));
            }
        }
        else
        {
            Console.WriteLine("Rossz formátum");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Rossz formátum");
    }


}
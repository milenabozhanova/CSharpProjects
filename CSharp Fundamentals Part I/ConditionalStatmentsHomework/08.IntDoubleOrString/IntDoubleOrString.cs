using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.WriteLine("Please enter \"1\" for int, \"2\" for double and \"3\" for string");
        int choise = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a value of the chosen variable");
        string variable = Console.ReadLine();

        switch (choise)
        {
            case 1:
                int intVariable = int.Parse(variable);
                Console.WriteLine(intVariable + 1);
                break;
            case 2:
                double doubleVariable = double.Parse(variable);
                Console.WriteLine(doubleVariable + 1);
                break;
            case 3:
                Console.WriteLine(variable + "*");
                break;
            default:
                Console.WriteLine("Ivalid choise");
                break;
        }
    }
}


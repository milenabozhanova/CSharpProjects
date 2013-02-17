using System;

class PrintMyAge
{
    static void Main()
    {
        AskQuastion();
    }

    static void AskQuastion()
    {
        Console.WriteLine("How old are you? (please write it using digits) ");

        string yourAge = Console.ReadLine();
        int age = 0;
        bool isNumber = int.TryParse(yourAge, out age);
        if (isNumber && age >= 0 && age < 130)
        {
            int futureAge = age + 10;
            Console.WriteLine("Your age after 10 years will be: {0}", futureAge);
        }
        else
        {
            Console.WriteLine("Don't try to cheat!");
            AskQuastion();
        }
    }

}

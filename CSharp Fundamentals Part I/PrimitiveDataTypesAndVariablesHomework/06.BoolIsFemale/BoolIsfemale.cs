using System;

class BoolIsfemale
{
    static void Main()
    {
        Console.Write("Try to guess my gender (for male type:M, for female type:F): ");
        string yourgender = (Console.ReadLine());
        bool isFemale = false;

        if (yourgender == "M")

            {
                isFemale = false;
                Console.WriteLine("Your suggestion is: {0}", isFemale);
            }

        else if (yourgender == "F")
            {
                isFemale = true;
                Console.WriteLine("Your suggestion is: {0}", isFemale);
            }
        else
        {
            Console.WriteLine("Your answer is incorrect");
        }
    }
}

using System;

class PrintContinuingNumbers
{
    static void Main()
    {
        int firstNumber = 1;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(++firstNumber * 1);
            Console.WriteLine(++firstNumber * -1);
        }
    }
}

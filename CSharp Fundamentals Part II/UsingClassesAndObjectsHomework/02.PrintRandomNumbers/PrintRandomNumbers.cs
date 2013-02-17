using System;

class PrintRandomNumbers
{
    static void Main()
    {
        Random randomGen = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}", randomGen.Next(100, 201));
        }
    }
}

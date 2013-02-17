using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        double n = int.Parse(Console.ReadLine());

        if (n >= 0)
        {

            double factorial2N = 1;
            for (double i = (n + 1); i <= 2 * n; i++)
            {
                factorial2N *= i;
            }


            double factorialNminus1 = 1;
            for (double i = 1; i <= (n+1); i++)
            {
                factorialNminus1 *= i;
            }
            Console.WriteLine("The {0} Catalan Number is: {1}", n, (factorial2N / factorialNminus1));
        }
        else
        {
            Console.WriteLine("Error: it should be n >= 0");
        }
    }
}


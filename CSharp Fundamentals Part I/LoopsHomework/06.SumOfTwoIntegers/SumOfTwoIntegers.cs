using System;

class SumOfTwoIntegers
{
    static void Main()
    {
        checked
        {
            Console.WriteLine("Please enter 2 integer number, so that n > 0 and x > 0");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());



            if (x > 0 && n > 0)
            {
                double factorialN = 1;
                double sum = 1;
                Console.Write("Sum = 1 ");

                double xSquare = 1;

                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                    xSquare *= x;
                    sum += (factorialN / xSquare);

                    Console.Write("+ {0}!/{1} ", i, xSquare);
                }

                Console.Write("= {0} ", sum);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}


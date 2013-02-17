using System;

    class OddOrEvenInteger
    {
        static void Main()
        {
            Console.Write("Please enter one number: ");

            int number = Convert.ToInt32(Console.ReadLine());
            int divider = 2;

            if (number % divider == 0)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is even");
            }
        }
    }

using System;

    class ExchangeIntValue
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a= {0}", a);
            Console.WriteLine("b= {0}", b);
        }
    }

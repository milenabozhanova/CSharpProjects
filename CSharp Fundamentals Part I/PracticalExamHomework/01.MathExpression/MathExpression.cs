using System;
using System.Threading;
using System.Globalization;


class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

         decimal n = decimal.Parse(Console.ReadLine());
         decimal m = decimal.Parse(Console.ReadLine());
         decimal p = decimal.Parse(Console.ReadLine());
       
         decimal numerator = (n * n) + (1 / (m * p)) + 1337;
         decimal denominator = n - (128.523123123m * p);
         decimal firstPart = numerator / denominator;
         decimal secuondPart = (decimal)Math.Sin((int)m % 180);
               
         decimal expression = firstPart + secuondPart;
         Console.WriteLine("{0:F6}", expression);      
    }
}


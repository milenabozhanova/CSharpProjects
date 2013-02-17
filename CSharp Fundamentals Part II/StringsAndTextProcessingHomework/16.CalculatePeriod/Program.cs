using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter two dates in format YYYY, MM, DD");
        DateTime start = DateTime.Parse(Console.ReadLine());
        DateTime end = DateTime.Parse(Console.ReadLine());

        int period = Math.Abs((start - end).Days);

        Console.WriteLine("Distance: {0} days", period);
    }
}

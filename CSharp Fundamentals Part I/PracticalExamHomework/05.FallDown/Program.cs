using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDown
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[8];
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
 
            byte counter = 7;
            int temp = 0;

            do
            {
                for (byte i = 1; i < numbers.Length; i++)
                {
                    temp = numbers[i] & numbers[i - 1];
                    numbers[i] = numbers[i] | numbers[i - 1];
                    numbers[i - 1] = temp;
                }
                counter--;
            }
            while (counter > 0);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}

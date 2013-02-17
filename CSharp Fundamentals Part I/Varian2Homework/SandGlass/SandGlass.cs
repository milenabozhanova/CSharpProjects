using System;

namespace SandGlass
{
    class SandGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] oneWay = new string[n / 2 + 1];
            for (int i = 0; i < n; i++)
            {
                if (n - 2 * i > 0)
                {
                    string rowTxt = "*";
                    rowTxt = rowTxt.PadRight(n - 2 * i, '*');
                    rowTxt = rowTxt.PadLeft(n - i, '.');
                    rowTxt = rowTxt.PadRight(n, '.');
                    oneWay[i] = rowTxt;
                    Console.WriteLine(rowTxt);
                }
                else { break; }
            }

            for (int a = oneWay.Length-2; a >= 0; a--)
            {
                Console.WriteLine(oneWay[a]);
            }
        }
    }
}

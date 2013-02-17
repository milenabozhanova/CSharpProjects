using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a hexadeciamal number (e.g.: 0xA23): 0x");
        string hexNum = Console.ReadLine();

        int decNum = 0;

        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            switch (hexNum[i])
            {
                case 'A': decNum += 10 * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
                case 'B': decNum += 11 * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
                case 'C': decNum += 12 * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
                case 'D': decNum += 13 * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
                case 'E': decNum += 14 * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
                case 'F': decNum += 15 * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
                default: decNum += (hexNum[i] - '0') * (int)Math.Pow(16, hexNum.Length - 1 - i); break;
            }
        }

        Console.WriteLine(decNum);
    }
}

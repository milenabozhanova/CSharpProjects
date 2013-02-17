using System;
using System.Collections.Generic;

class DecimalToHexaDecimal
{
    static void Main()
    {
        int decNum = int.Parse(Console.ReadLine());

        List<char> hexNum = new List<char>();

        while (decNum > 0)
        {
            switch (decNum % 16)
            {
                case 10:
                    hexNum.Add('A');
                    break;
                case 11:
                    hexNum.Add('B');
                    break;
                case 12:
                    hexNum.Add('C');
                    break;
                case 13:
                    hexNum.Add('D');
                    break;
                case 14:
                    hexNum.Add('E');
                    break;
                case 15:
                    hexNum.Add('F');
                    break;
                default:
                    hexNum.Add((char)(decNum % 16+48));
                    break;
            }
            decNum = decNum / 16;
        }

        hexNum.Reverse();

        foreach (var n in hexNum)
        {
            Console.Write(n);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{

    static char BinToHex(string num)
    {
        int res = 0;

        // for each 4 bits in binary make the following:
        // 1000 0011 - binary
        // 8421 8421 - coeficient (to sum)
        //  8    3   - result
        for (int i = 0; i < 4; i++)
        {
            if (num[i] == '1')
            {
                switch (i)
                {
                    case 0:
                        res += 8;
                        break;
                    case 1:
                        res += 4;
                        break;
                    case 2:
                        res += 2;
                        break;
                    case 3:
                        res += 1;
                        break;
                    default:
                        break;
                }
            }
        }
        // if the result is bigger than 9 - replace with letters - A to F
        return IntToHex(res);
    }

    private static char IntToHex(int input)
    {
        if (input > 9)
        {
            switch (input)
            {
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                default:
                    break;
            }
        }
        return input.ToString()[0];
    }
    
    static void Main()
    {
        Console.Write("Please enter a binary number (e.g.: 10010): ");
        string binNum = Console.ReadLine();

        if (binNum.Length % 4 != 0)
        {
            int dif = binNum.Length % 4;
            binNum = binNum.PadLeft(binNum.Length + (4 - dif), '0');
        }

        List<char> hex = new List<char>();

        for (int i = 0; i < binNum.Length; i+=4)
        {
            hex.Add(BinToHex(binNum.Substring(i, 4)));
           
        }

        //print the result
        Console.Write("The hexadecimal number is: 0x");
        foreach (var el in hex)
        {
            Console.Write(el);
        }
        Console.WriteLine();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumeralSystem
{
    static void Main()
    {
        int fromSystem = int.Parse(Console.ReadLine());
        int toSystem = int.Parse(Console.ReadLine());
        string numb = Console.ReadLine().ToUpper();

        if (!(fromSystem >= 2 && toSystem <= 16))
        {
            Console.WriteLine("Invalid number system!");
        }
        else if (!ValidateNumber(fromSystem, numb))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            int numIn10 = ConvertTo10System(fromSystem, numb);
            string res = Convert10ToRandomSystem(toSystem, numIn10);
            Console.WriteLine(res);
        }
    }

    private static bool ValidateNumber(int fromSystem, string numb)
    {
        for (int i = 0; i < fromSystem; i++)
        {
            numb = numb.Replace(GetValueAsChar(fromSystem,i), "");
        }

        return numb.Length == 0;
    }

    private static string Convert10ToRandomSystem(int toSystem, int numIn10)
    {
        string res = string.Empty;

        do
        {
            int ost = numIn10 % toSystem;
            numIn10 = numIn10 / toSystem;
            res = GetValueAsChar(toSystem, ost) + res;
        }
        while (numIn10 > 0);

        return res;
    }

    private static int ConvertTo10System(int fromSystem, string numb)
    {
        int res = 0;

        for (int i = numb.Length - 1; i >= 0; i--)
        {
            res += GetCharValue(fromSystem, numb[i]) * (int)Math.Pow(fromSystem, numb.Length - i - 1);
        }

        return res;
    }

    private static int GetCharValue(int fromSystem, char p)
    {
        if (fromSystem > 9 &&  p > 9)
        {
            switch (p)
            {
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    break;
            }
        }

        return int.Parse(p.ToString());
    }

    private static string GetValueAsChar(int toSystem, int p)
    {
        if (toSystem > 9 && p > 9)
        {
            switch (p)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    break;
            }
        }

        return p.ToString();
    }
}
using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        string number = Console.ReadLine();
        char[] binarNum = new char [number.Length];

        //reverse of the bits
        for (int i = number.Length -1; i >=0; i--)
        {
            binarNum[number.Length - 1 - i] = number[i];
        }

        int decimalNum = 0;

        for (int i = 0; i < binarNum.Length; i++)
        {
            if (binarNum[i]=='1')
            {
               decimalNum += (int)Math.Pow(2,i);
            }

        }

        Console.WriteLine(decimalNum);
    }
}


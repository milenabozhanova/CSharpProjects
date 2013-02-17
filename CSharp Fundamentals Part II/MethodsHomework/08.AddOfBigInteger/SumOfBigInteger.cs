using System;
using System.Collections.Generic;

class SumOfBigInteger
{
    static int[] NumberToArray(string number)
    {
        int[] numArr = new int[number.Length];

        for (int i = number.Length-1; i >=0; i--)
        {
            numArr[number.Length - 1 - i] = int.Parse(number[i].ToString());
        }
        return numArr;
    }

    static string SumNumbers(string first, string secound)
    {
        int[] firstArr = NumberToArray(first);
        int[] secoundArr = NumberToArray(secound);

        int maxLen = Math.Max(firstArr.Length, secoundArr.Length);
        int minLen = Math.Max(firstArr.Length, secoundArr.Length);

        int[] sumArr = new int[maxLen + 1];

        for (int i = 0; i < minLen; i++)
        {
            sumArr[i] += firstArr[i] + secoundArr[i];
            if (sumArr[i] > 9)
            {
                sumArr[i] = sumArr[i] - 10;
                sumArr[i + 1] = 1;
            }
        }

        Array.Reverse(sumArr);
        return string.Join("", sumArr).TrimStart('0'); 
    }

    static void Main(string[] args)
    {
        string first = Console.ReadLine();
        string secound = Console.ReadLine();

        string sum = SumNumbers(first, secound);
        Console.WriteLine(sum);
    }
}

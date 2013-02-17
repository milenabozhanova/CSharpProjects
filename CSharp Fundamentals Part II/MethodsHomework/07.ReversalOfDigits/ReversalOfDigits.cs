using System;
using System.Collections.Generic;

class ReversalOfDigits
{   
    static void Main()
    {
        string number = Console.ReadLine();

        char[] result = ReverseNumber(number);

        foreach (var digit in result)
	    {
		 Console.Write(digit);
	    }
        Console.WriteLine();
    }

    static char[] ReverseNumber(string num)
    {
        char[] revNum = num.ToCharArray();
        Array.Reverse(revNum);
        return revNum;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubstringAppearance
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't have anything else.
        Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
       

        string textLower = text.ToLower();

        string keyword = "in";

        int index = textLower.IndexOf(keyword);
        int cnt = 0;

        while (index !=-1)
        {
            cnt++;
            index = textLower.IndexOf(keyword, index + 1);
        }

        Console.WriteLine("\"{0}\" appears in the given text: {1} times", keyword, cnt);
    }
}
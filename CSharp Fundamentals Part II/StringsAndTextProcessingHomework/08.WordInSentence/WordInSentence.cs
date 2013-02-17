using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class WordInSentence
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't have anything else.
        Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string keyword = "in";

        string[] sentences = text.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.IsMatch(sentences[i], @"\b" + keyword + @"\b", RegexOptions.IgnoreCase))
            {
                Console.WriteLine((sentences[i] + ".").Trim());
            }
        }
    }
}

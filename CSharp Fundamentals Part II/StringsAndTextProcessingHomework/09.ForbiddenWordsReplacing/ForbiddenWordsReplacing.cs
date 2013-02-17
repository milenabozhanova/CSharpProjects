using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ForbiddenWordsReplacing
{
    static void Main()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 
        and is implemented as a dynamic language in CLR.";

        string wordsStr = "PHP, CLR, Microsoft";
        char[] separators = {' ', ','};

        string[] words = wordsStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            //text = text.Replace(words[i], new string('*', words[i].Length));
            text = Regex.Replace(text, string.Format(@"\b{0}\w*\b", words[i]), new String('*', words[i].Length));
        }

        Console.WriteLine(text);
    }
}

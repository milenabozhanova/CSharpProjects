using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PalindromesExtracting
{
    static void Main()
    {
        string text = "This is text with palindromes like ABBA, exe, lamal.";

        char[] separators = { ' ', ',', '!', '?', '.' };

        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (IsPolindrom(words[i]))
            {
                Console.WriteLine(words[i]);
            }
        }        
    }

    static bool IsPolindrom(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}

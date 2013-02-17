using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumbersOfWordsInText
{
    static void Main()
    {
        string text = Console.ReadLine();

        char[] separators = { ' ', ',', '!', '?', '.' };

        string[] allWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(allWords);

        Dictionary<string, int> words = new Dictionary<string, int>();

        for (int i = 0; i < allWords.Length; i++)
        {
            if (!words.ContainsKey(allWords[i]))
            {
                words.Add(allWords[i], 1);
            }
            else if (words.ContainsKey(allWords[i]))
            {
                words[allWords[i]] += 1;
            }
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WordsInAlpabeticalOrder
{
    static void Main()
    {
        string text = "separated words by spaces and prints the list in an alphabetical order";

        string[] words = text.Split(' ');

        Array.Sort(words);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
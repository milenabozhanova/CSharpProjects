using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumbersOfLettersInString
{
    static void Main()
    {
        string text = Console.ReadLine();

        text.ToLower();

        Dictionary<char, int> letters = new Dictionary<char, int>();

        //fill the keys in dictionary
        for (char i = 'a'; i <= 'z'; i++)
        {
            letters.Add(i, 0);
        }

        //fill values in dictionary (how many times each letter is found)
        for (int i = 0; i < text.Length; i++)
        {
            if (letters.ContainsKey(text[i]))
            {
                letters[text[i]] +=1;
            }
        }

        //print only the letters from text
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (letters[i] > 0)
            {
                Console.WriteLine("{0}: {1} times", i, letters[i]);
            }
        }
    }
}

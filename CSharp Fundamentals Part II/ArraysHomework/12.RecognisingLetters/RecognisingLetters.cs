using System;
using System.Collections.Generic;
using System.Linq;

class RecognisingLetters
{
    static void Main()
    {
        char[] alphabet = new char[52];

        //Upercase - 'A' in ASCII is 65
        for (int i = 0; i < alphabet.Length/2; i++)
        {
            alphabet[i] = (char)(i + 65);
        }

        //lowercase - 'a' in ASCII is 97 (97-26 = 71)
        for (int i = 26; i < alphabet.Length ; i++)
        {
            alphabet[i] = (char)(i + 71);
        }

        string word = Console.ReadLine();

        foreach (char letter in word)
        {
            for (int index = 0; index < alphabet.Length; index++)
            {
                if (letter == alphabet[index])
                {
                    Console.WriteLine(letter + "-" + index + " ");
                }
            }
        }
    }
}


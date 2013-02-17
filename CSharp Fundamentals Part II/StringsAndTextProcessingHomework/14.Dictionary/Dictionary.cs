using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add(".NET", "- platform for applications from Microsoft");
        dictionary.Add("CLR","- managed execution environment for .NET" );
        dictionary.Add("namespace", "- hierarchical - organization of classes");

        string word = Console.ReadLine();


        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine(dictionary[word]);
        }
        else 
        {
            Console.WriteLine("The word isn't in the dictionary");
        }        
    }
}

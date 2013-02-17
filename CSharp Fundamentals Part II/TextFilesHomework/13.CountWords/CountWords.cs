using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        SortedList<string, int> wordsCounts = new SortedList<string, int>();
        using (StreamReader fileReader = new StreamReader(@"../../words.txt"))
        {
            string allText = fileReader.ReadToEnd();
            string[] inputWords = allText.Split();
            for (int i = 0; i < inputWords.Length; i++)
            {
                if (inputWords[i] != string.Empty)
                {
                    if (!wordsCounts.ContainsKey(inputWords[i]))
                    {
                        wordsCounts.Add(inputWords[i], 0);
                    }
                }
            }
        }


        using (StreamReader fileReader = new StreamReader(@"../../text1.txt"))
        {
            string line = fileReader.ReadLine();

            while (line != null)
            {
                for (int w = 0; w < wordsCounts.Keys.Count; w++)
                {
                    string word = wordsCounts.Keys[w];
                    string pattern = string.Format(@"\b{0}\b", word);
                    int NumberOfTrues = Regex.Matches(line, pattern).Count;

                    wordsCounts[word] += NumberOfTrues;
                }
                line = fileReader.ReadLine();
            }
        }

        using (StreamWriter fileWriter = new StreamWriter(@"../../result.txt"))
        {
            for (int w = wordsCounts.Keys.Count - 1; w >= 0; w--)
            {
                string word = wordsCounts.Keys[w];
                fileWriter.WriteLine(string.Format("{0} - {1}", word, wordsCounts[word]));
            }
        }
    }
}
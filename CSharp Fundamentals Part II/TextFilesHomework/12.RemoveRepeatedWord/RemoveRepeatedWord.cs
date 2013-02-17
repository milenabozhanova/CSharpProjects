using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveRepeatedWord
{
    static void Main()
    {
        string[] words = null;
        using (StreamReader fileReader = new StreamReader(@"../../words.txt"))
        {
            string allText = fileReader.ReadToEnd();
            words = allText.Split(' ','\r');
        }

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Replace("\n", "").Replace(",", "").Replace(".", "");
        }

        using (StreamWriter fileWriter = new StreamWriter(@"../../result.txt"))
        {
            using (StreamReader fileReader = new StreamReader(@"../../text1.txt"))
            {
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    foreach (string word in words)
                    {
                        line = Regex.Replace(line, string.Format(@"\b{0}\w*\b", word), string.Empty);
                    }
                    fileWriter.WriteLine(line);
                    line = fileReader.ReadLine();
                }
            }
        }
    }
}

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReadsWordsWithPrefix
{
    static void Main()
    {
        using (StreamWriter fileWriter = new StreamWriter(@"../../result.txt"))
        {
            using (StreamReader fileReader = new StreamReader(@"../../text1.txt"))
            {
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    fileWriter.WriteLine(Regex.Replace(line, @"\btest\w*\b", string.Empty));
                    line = fileReader.ReadLine();
                }
            }
        }
    }
}
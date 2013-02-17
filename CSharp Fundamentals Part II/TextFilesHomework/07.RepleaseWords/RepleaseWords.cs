using System;
using System.IO;

class RepleaseWords
{
    static void Main()
    {
        StreamReader fileReader = new StreamReader(@"..\..\text1.txt");
        StreamWriter fileWriter = new StreamWriter(@"..\..\result.txt");

        string text = string.Empty;

        using (fileReader)
        {
            text = fileReader.ReadToEnd();
        }

        text = text.Replace("start", "finish");

        using (fileWriter)
        {
            fileWriter.Write(text);
        }
    }
}
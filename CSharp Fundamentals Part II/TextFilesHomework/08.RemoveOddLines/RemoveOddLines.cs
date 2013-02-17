using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class RemoveOddLines
{
    static void Main()
    {
        StreamReader fileReader = new StreamReader(@"..\..\text1.txt");

        List<string> newText = new List<string>();

        using (fileReader)
        {
            int lineNumber = 1;
            string line = fileReader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    newText.Add(line);
                }
                line = fileReader.ReadLine();
                lineNumber++;
            }
        }

        StreamWriter fileWriter = new StreamWriter(@"..\..\result.txt");
        using (fileWriter)
        {
            foreach (var line in newText)
            {
                fileWriter.WriteLine(line);
            }
            
        }
    }
}

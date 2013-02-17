using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class StringSorting
{
    static void Main()
    {
        StreamReader fileReader = new StreamReader(@"..\..\text1.txt");
        StreamWriter fileWriter = new StreamWriter(@"..\..\result.txt");

        List<string> names = new List<string>();
        using (fileReader)
        {
            string line = fileReader.ReadLine();
            while (line != null)
            {
                names.Add(line.Trim());
                line = fileReader.ReadLine();
            }
        }

        names.Sort();

        using (fileWriter)
        {
            foreach (string item in names)
            {
                fileWriter.WriteLine(item);
            }
        }
    }
}

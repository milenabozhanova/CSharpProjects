using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ReadXMLfile
{
    static void Main()
    {
        StreamReader fileReader = new StreamReader(@"..\..\text1.txt");

        using (fileReader)
        {
            string line = fileReader.ReadLine();
            while (line != null)
            {
                string pattern = ">[^<]*</"; 
                string edited;
                int length;
                foreach (Match match in Regex.Matches(line, pattern))
                {
                    edited = match.Value.ToString();
                    length = edited.Length;
                    edited = edited.Remove(length - 2, 2); 
                    edited = edited.Remove(0, 1); 
                    if (edited != null)
                    {
                        Console.WriteLine(edited);
                    }
                }
                line = fileReader.ReadLine();
            }
        }
    }
}

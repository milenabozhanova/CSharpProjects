using System;
using System.IO;


class PrintsOddLines
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../Earthquakes.txt");

            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber += 2;
                    Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine(
              "File not found.");
        }


    }
}

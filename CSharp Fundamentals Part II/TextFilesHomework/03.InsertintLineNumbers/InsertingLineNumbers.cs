using System;
using System.IO;

class InsertingLineNumbers
{
    static void Main()
    {
        StreamReader firstText = new StreamReader(@"..\..\text1.txt");
        StreamWriter writer = new StreamWriter(@"..\..\sum.txt");

        using (firstText)
        {
            string line = firstText.ReadLine();
            int lineNumber = 0;
            while (line != null)
            {
                lineNumber++;
                writer.WriteLine("{0}. {1}", lineNumber, line);

                line = firstText.ReadLine();
            }

            writer.Close();
        }
    }
}

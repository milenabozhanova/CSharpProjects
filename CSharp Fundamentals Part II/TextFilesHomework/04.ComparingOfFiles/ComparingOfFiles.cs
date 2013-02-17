using System;
using System.IO;

class ComparingOfFiles
{
    static void Main()
    {
        StreamReader firstText = new StreamReader(@"..\..\text1.txt");
        StreamReader secoundText = new StreamReader(@"..\..\text2.txt");

        string firstFLines = firstText.ReadLine();
        string secoundFLines = secoundText.ReadLine();
        int line = 0;

        while (firstFLines != null)
        {
            line++;

            if (firstFLines == secoundFLines)
            {
                Console.WriteLine("Lines {0} are equal", line);
            }
            else
            {
                Console.WriteLine("Lines {0} are different", line);
            }

            firstFLines = firstText.ReadLine();
            secoundFLines = secoundText.ReadLine();
        }

        firstText.Close();
        secoundText.Close();
    }
}

 
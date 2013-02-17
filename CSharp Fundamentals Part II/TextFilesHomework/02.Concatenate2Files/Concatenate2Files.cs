using System;
using System.IO;

class Concatenate2Files
{
    static void Main()
    {
        StreamReader firstText = new StreamReader(@"..\..\text1.txt");
        StreamReader secoundText = new StreamReader(@"..\..\text2.txt");
        StreamWriter writer = new StreamWriter(@"..\..\sum.txt");

        string all = string.Empty;
        using (firstText)
        {
            all = firstText.ReadToEnd();
        }

        using (secoundText)
        {
            all = all + secoundText.ReadToEnd();
        }

        using (writer)
        {
            writer.Write(all);
        }
    }
}

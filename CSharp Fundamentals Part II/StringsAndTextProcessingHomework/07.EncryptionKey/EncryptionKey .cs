using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EncryptionKey
{
    static void Main()
    {
        string text = "Nakov";

        string key = "ab";
        int z = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (z > key.Length-1)
            {
                z = 0;
            }
            
            Console.Write(@"\u{0:x4}", (ushort)text[i] ^ (ushort)key[z]);
            z++;
        }
        Console.WriteLine();
    }
}

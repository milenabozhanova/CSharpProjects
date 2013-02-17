using System;
using System.Text;

    class TriangleOfCopyrightSymbols
    {
        static void Main()
        {
            byte numberOfSymbols = 9;
            char copyrightSymbol = '\u00a9';
            Console.OutputEncoding = Encoding.Unicode;

            byte triangleHeight = (byte)Math.Sqrt(numberOfSymbols);
            
            for (int triangleRow = 0; triangleRow < triangleHeight; triangleRow++)
            {
                Console.CursorLeft = triangleHeight - triangleRow;

                for (int col = 0; col <= 2* triangleRow; col++)
                {
                    Console.Write(copyrightSymbol);
                }
                Console.WriteLine();
            }
        }
    }

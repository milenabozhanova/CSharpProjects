using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    class RockInfo
    {
        public int X, Y, RockType, RockColor, RockSize;
        public RockInfo(int x, int y, int rType, int rColor, int rSize)
        {
            this.X = x;
            this.Y = y;
            this.RockType = rType;
            this.RockColor = rColor;
            this.RockSize = rSize;
        }
    }

    static void Main()
    {
        int windowHeight = 39;
        int windowWidth = 69;
        int maxRocksOnRow = 3;

        char[] rocks = { '^', '@', '*', '+', '%', '$', '#', '!', '.', ';' };
        ConsoleColor[] colorNames = {ConsoleColor.Blue, ConsoleColor.DarkGreen, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Gray};
        
        Console.SetWindowSize(windowWidth + 1, windowHeight + 1);
        Console.SetBufferSize(100, 40);

        int lastPosition = windowWidth/2;
        Random randX = new Random();
        List<RockInfo> rocksPositions = new List<RockInfo>(); 

        Console.SetCursorPosition(lastPosition, windowHeight);
        Console.Write("0");

        DateTime startGame = DateTime.Now;
        while (true)
        {
            Thread.Sleep(150);
            
            for (int i = 0; i < rocksPositions.Count; i++)
            {
                // remove last position
                Console.SetCursorPosition(rocksPositions[i].X, rocksPositions[i].Y);
                
                for (int r = 1; r <= rocksPositions[i].RockSize; r++)
                {
                    Console.Write(" ");
                }

                if (rocksPositions[i].Y >= windowHeight)
                {
                    rocksPositions.RemoveAt(i);
                    i--;
                }
                else
                {
                    // set new position
                    rocksPositions[i].Y++;
                    if (rocksPositions[i].Y == windowHeight && rocksPositions[i].X == lastPosition)
                    {
                        //game over!
                        DateTime endGame = DateTime.Now;
                        for (int c = 0; c < rocksPositions.Count; c++)
                        {
                            // remove all rocks
                            Console.SetCursorPosition(rocksPositions[c].X, rocksPositions[c].Y);

                            for (int r = 1; r <= rocksPositions[c].RockSize; r++)
                            {
                                Console.Write(" ");
                            }

                            if (rocksPositions[c].Y >= windowHeight)
                            {
                                rocksPositions.RemoveAt(c);
                                c--;
                            }
                        }
                        Console.SetCursorPosition(lastPosition, windowHeight);
                        Console.Write(" ");


                        Console.SetCursorPosition(windowWidth / 2 - 5, windowHeight / 2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Game Over!");
                        Console.SetCursorPosition(windowWidth / 2 - 8, (windowHeight / 2) + 1);
                        Console.Write("Your score: {0} sec.", (endGame - startGame).TotalSeconds.ToString("N0"));
                        Console.SetCursorPosition(windowWidth / 2 - 14, (windowHeight / 2) + 2);
                        return;
                    }
                    Console.SetCursorPosition(rocksPositions[i].X, rocksPositions[i].Y);
                    Console.ForegroundColor = colorNames[rocksPositions[i].RockColor];
                    for (int r = 1; r <= rocksPositions[i].RockSize; r++)
                    {
                        Console.Write(rocks[rocksPositions[i].RockType]);
                    }

                }
            }

            int maxRocks = randX.Next(1, maxRocksOnRow);           
            for (int i = 0; i <= maxRocks; i++)
            {
                // add new rocks
                int newRockX = randX.Next(0, windowWidth);
                int rockType = randX.Next(0, rocks.Length - 1);
                int rockColor = randX.Next(0, colorNames.Length - 1);
                int rockSize = randX.Next(1,3);
                Console.SetCursorPosition(newRockX, 0);
                Console.ForegroundColor = colorNames[rockColor];
                for (int r = 1; r <= rockSize; r++)
                {
                    Console.Write(rocks[rockType]);
                }
                rocksPositions.Add(new RockInfo(newRockX, 0, rockType, rockColor, rockSize));
            }

            Console.ResetColor();
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (lastPosition < windowWidth)
                    {
                        Console.SetCursorPosition(lastPosition, windowHeight);
                        Console.Write(" 0");
                        lastPosition++;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (lastPosition > 0)
                    {
                        lastPosition--;
                        Console.SetCursorPosition(lastPosition, windowHeight);
                        Console.Write("0 ");
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}


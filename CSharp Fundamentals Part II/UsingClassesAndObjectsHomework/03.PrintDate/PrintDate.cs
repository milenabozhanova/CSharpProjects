﻿using System;

class PrintDate
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}

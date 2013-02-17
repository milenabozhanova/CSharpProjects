using System;

class CalculateWorkdays
{
    public static void Main()
    {
        DateTime[] holidays =
        {
            new DateTime(2013, 1, 1),
            new DateTime(2013, 3, 3),
            new DateTime(2013, 5, 1),
            new DateTime(2013, 5, 2),
            new DateTime(2013, 5, 6),
            new DateTime(2013, 5, 24),
            new DateTime(2013, 9, 22),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31)
        };

        DateTime start = DateTime.Today;

        Console.WriteLine("Please enter a date in format YYYY, MM, DD");
        DateTime end = DateTime.Parse(Console.ReadLine());

        int wholePeriod = 0;
        wholePeriod = Math.Abs((end - start).Days);

        int workDaysCnt = 0;

        bool isHoliday = false;

        for (int i = 0; i < wholePeriod; i++)
        {
            start = start.AddDays(1);
            if (start.DayOfWeek != DayOfWeek.Sunday && start.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (start == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDaysCnt++;
                }

                isHoliday = false;
            }
        }

        Console.WriteLine("The workdays in the period are {0}", workDaysCnt);
    }
}

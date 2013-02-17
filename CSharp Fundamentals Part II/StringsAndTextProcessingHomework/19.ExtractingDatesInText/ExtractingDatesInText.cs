using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractingDatesInText
{
    static void Main()
    {
        string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. 
        The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        DateTime date;

        foreach (Match item in Regex.Matches(text, @"\b\d{1,2}.\d{1,2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}

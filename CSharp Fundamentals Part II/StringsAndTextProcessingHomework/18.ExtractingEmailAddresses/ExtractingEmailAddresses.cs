using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractingEmailAddresses
{
    static void Main()
    {
        string text = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. 
        This is not email: test@test.This also: @telerik.com. Neither this: a@a.b.";

        string[] splitText = text.Split(' ');

        MatchCollection emails = Regex.Matches(text, @"([\w-\.]+)@((?:[\w]+\.)+)([a-z]{2,4})");

        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}

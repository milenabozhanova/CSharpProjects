using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class HTMLtextWithoutTags
{
    static void Main()
    {
        string html = @"<html>
        <head><title>News</title></head>
        <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical
        training for young people who want to turn into skillful .NET software engineers.</p></body>
        </html>";

        MatchCollection justText = Regex.Matches(html, @"(?<=^|>)[^><]+?(?=<|$)");

        foreach (var word in justText)
        {
            Console.WriteLine(word);
        }

    }
}

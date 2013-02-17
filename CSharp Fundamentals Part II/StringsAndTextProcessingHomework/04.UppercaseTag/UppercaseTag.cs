using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class UppercaseTag
{
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. 
        We don't have <upcase>anything</upcase> else.";

        Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));    
    }
}

using System;

class QuotedOrUnquotedString
{
    static void Main()
    {
        string unquotedString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(unquotedString);


        string quotedString = "The \x0022use\x0022 of quotations causes difficulties.";
        Console.WriteLine(quotedString);

        string quotedString2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedString2);
    }
}

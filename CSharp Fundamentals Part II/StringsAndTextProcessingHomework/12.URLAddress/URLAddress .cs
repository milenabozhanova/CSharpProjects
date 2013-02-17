using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class URLAddress
{
    static void Main()
    {
        string urlAddress = "http://www.devbg.org/forum/index.php ";

        Match protocol = Regex.Match(urlAddress, "[^:]*");
        Match server = Regex.Match(urlAddress, @"/([^/][\w\.]*)");
        Match resource = Regex.Match(urlAddress, @"\b/[^/][\w.]*.+");

        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server.Groups[1]);
        Console.WriteLine("[server] = \"{0}\"", resource);
    }
}

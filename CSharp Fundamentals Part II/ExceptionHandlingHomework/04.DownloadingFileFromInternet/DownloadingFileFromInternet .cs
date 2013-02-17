using System;
using System.Net;

class DownloadingFileFromInternet
{
    static void Main()
    {
        Console.WriteLine(@"Please enter a file name and url(e.g. http://www.devbg.org/img/Logo-BASD.jpg): ");
        string path = Console.ReadLine();

        WebClient client = new WebClient();
        using (client)
        {
            try
            {
                client.DownloadFile(path, @"C:\Users\Milena\Documents\Visual Studio 2012\Projects\ExceptionHandlingHomework\test.jpg");
            }
            catch (WebException webEx)
            {
                Console.WriteLine("{0} - {1}", webEx.GetType(), webEx.Message);
                Console.WriteLine("The Ardess is not found!");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("{0} - {1}", ae.GetType(), ae.Message);
            }
        }
    }
}

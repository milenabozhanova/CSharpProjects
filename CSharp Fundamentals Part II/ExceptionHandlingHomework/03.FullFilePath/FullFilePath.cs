using System;
using System.IO;

class FullFilePath
{
    static void Main()
    {
        try
        {
            Console.WriteLine(@"Please enter a file name along with its full file path (e.g. C:\WINDOWS\win.ini):");
            string userPath = Console.ReadLine();
            string fileContent = File.ReadAllText(userPath);
            Console.WriteLine(fileContent);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("There is no such directory");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File was not found");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file path is wrong");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
    }
}

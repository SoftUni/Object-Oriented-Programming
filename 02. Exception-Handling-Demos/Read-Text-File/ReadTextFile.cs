using System;
using System.IO;

public class ReadTextFile
{
    private const string FilePath = @"..\..\ReadTextFile.cs";
    
    public static void Main()
    {
        StreamReader reader = null;

        try
        {
            reader = new StreamReader(FilePath);
            int lineNumber = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File {0} not found", FilePath);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("File path contains an invalid directory");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized access to specified file path");
        }
        catch (IOException)
        {
            Console.WriteLine("Unknown IO has occurred. Verify that the file path is correct.");
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();                
            }
        }
    }
}

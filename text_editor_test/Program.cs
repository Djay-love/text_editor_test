using System.IO;

namespace text_editor_test
{
    internal class Program
    {
        static string filePathTemplate = @"C:\Users\Jonge Onderzoekers\Desktop\FileLib";
        static string filePath = filePathTemplate;

        static void Main(string[] args)
        {
            GetFileNames();
            Console.ReadKey();
        }

        static void GetFileNames()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            foreach (var path in Directory.GetFiles(filePathTemplate))
            {
                Console.WriteLine(Path.GetFileName(path));
            }

            Console.WriteLine("\n============================");
            Console.WriteLine("Choose the file to read; ");

            string answer = Console.ReadLine();
            ReadFile(filePathTemplate + @"\" + answer);
        }

         static void ReadFile(string path)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            try
            {
                // Create a StreamReader
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            GetFileNames();
        }
    }
}

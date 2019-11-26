using System;

namespace FacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                string file = args[0];
                string format = args[1];
                Console.WriteLine($"Converting \"{file}\" into {format}");
                SimpleConverter converter = new SimpleConverter();
                try
                {
                    converter.Convert(file, format);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error. ExeptionType={ex.GetType()}. ExeptionMessage=\"{ex.Message}\"");
                }
            }
            else
            {
                Console.WriteLine("Invalid arguments. Usage: \"FacadeApp.exe <file_path> <format>\"");
            }
            Console.ReadKey();
        }
    }
}

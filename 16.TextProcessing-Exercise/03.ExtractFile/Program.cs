using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine().Split("\\");

            var file = path[path.Length - 1].Split(".");

            var fileName = file[0];
            var fileExtension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

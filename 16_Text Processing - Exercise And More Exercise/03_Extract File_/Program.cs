using System;

namespace _03_Extract_File_
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split("\\");
            string file = arr[arr.Length - 1];

            string fileName = file.Substring(0, file.LastIndexOf('.'));
            string fileExtension = file.Substring(file.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

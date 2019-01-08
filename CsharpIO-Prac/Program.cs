using System;
using System.IO;

namespace CsharpIO_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            var files = directory.GetFiles("*.txt");

            foreach(var file in files)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}

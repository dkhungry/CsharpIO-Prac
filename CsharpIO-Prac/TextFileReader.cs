﻿using System;
using System.IO;

namespace CsharpIO_Prac
{
    class TextFileReader
    {
        public static void PrintText()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            var fileName = Path.Combine(directory.FullName, "data.txt");
            var file = new FileInfo(fileName);
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }
            }
        }
    }
}

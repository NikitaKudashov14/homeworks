using System;
using System.IO;
using System.Text.RegularExpressions;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Никита\OneDrive\Рабочий стол\1.txt";
            string[] arr = Regex.Split(File.ReadAllText(path), @"(?<=[\.!\?])\s+");

            foreach(string item in arr)
            {
                if (!item.Contains(","))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}


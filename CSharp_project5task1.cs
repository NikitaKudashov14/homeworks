using System;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Язык программирования C#";
            string reverse_str = string.Join(" ", str.Split().Reverse());
            Console.WriteLine(reverse_str);

            string reverse_str2 = string.Concat(str.Reverse());
            Console.WriteLine(reverse_str2);


        }
    }
}

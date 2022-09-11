using System;
using System.Globalization;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            

            string user_input = Console.ReadLine();
            if (user_input.Contains("."))
            {
                double a1 = double.Parse(user_input, numberFormatInfo);
                double z1 = Math.Cos(a1) + Math.Sin(a1) + Math.Cos(3 * a1) + Math.Sin(3 * a1);
                double z2 = 2 * Math.Sqrt(2) * Math.Cos(a1) * Math.Sin((Math.PI / 4) + 2 * a1);
                Console.WriteLine("Значение функции z1 = " + Math.Round(z1, 4));
                Console.WriteLine("Значение функции z2 = " + Math.Round(z2, 4));

            } else
            {
                int a1 = int.Parse(user_input);
                double z1 = Math.Cos(a1) + Math.Sin(a1) + Math.Cos(3 * a1) + Math.Sin(3 * a1);
                double z2 = 2 * Math.Sqrt(2) * Math.Cos(a1) * Math.Sin((Math.PI / 4) + 2 * a1);
                Console.WriteLine("Значение функции z1 = " + Math.Round(z1, 4));
                Console.WriteLine("Значение функции z2 = " + Math.Round(z2, 4));
            }

            


            



        }
    }
}
            

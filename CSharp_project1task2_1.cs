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

            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string x1 = Console.ReadLine();
            double a = int.Parse(a1);
            double b = int.Parse(b1);
            double x = int.Parse(x1);

            double y1 = Math.Log(x * x) - Math.Asin(x / 10);
            double y2 = Math.Atan(2 * x - 0.6) + 2 * Math.Log(x);

            double result = (3 * a > 2 * b) ? y1 : y2;
            Console.WriteLine(result);







        }
    }
}
            

    

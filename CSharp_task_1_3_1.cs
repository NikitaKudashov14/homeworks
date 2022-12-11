using System;
using System.Globalization;

namespace ConsoleApp13
{
    class Program
    {
        public delegate double Operation(double x);

        public static double MethodPolDel(double e, double a, double b, Operation operation)
        {
            while (Math.Abs(b - a) > e)
            {
                double xc = (a + b) / 2;
                if (operation(a) * operation(xc) < 0)
                    b = xc;
                else a = xc;
            }
            return a;
        }

        static void Main(string[] args)
        {

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo() {
                NumberDecimalSeparator = ".",
            }; 

            Operation operation = (x) => 2 * x + 3;
            Console.WriteLine("Введите по очереди: точность вычисления (e), первая точка отрезка (a), вторая точка отрезка (b)");
           
            double e = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);
            double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);
            double b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);
            double result = MethodPolDel(e, a, b, operation);
            Console.WriteLine(result);
        }
    }
}

using System;
using System.IO.Pipes;

namespace laba13
{
    class Program
    {
        public delegate double Funcc(double x);
        public static double Method(double e, double a, double b, Funcc f)
        {
            while (Math.Abs(b - a) > e)
            {
                double x = (a + b) / 2;
                if (f(a) * f(x) < 0)
                {
                    b = x;
                }
                else a = x;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Funcc funcc = x =>x*x-7;
            Console.Write("Введите значение погрешности(e): ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("Введите начало отрезка(a): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите конец отрезка(b): ");
            double b = double.Parse(Console.ReadLine());
            double result = Method(e, a, b, funcc);
            double result1 = Math.Abs(Method(e,a,b,funcc));
            Console.WriteLine(result);
            if(result!=result1)
            {
            Console.WriteLine(result1);
            }
        }
    }
}

using System;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            static double f(double x)
            {
                double r = 2;
                double y = 0;

                if (x < -6.0)
                    y = 2;

                if (x >= -6.0 && x <= -2)
                    y = 1.0 / 4.0 * x + 1.0 / 2.0;

                if (x > -2 && x <= 0)
                    y = 2 - Math.Sqrt(r * r - (x + 2) * (x + 2));

                if (x > 0 && x <= 2)
                    y = Math.Sqrt(r * r - x * x);

                if (x > 2)
                    y = -x + 2;


                return y;
            }
            static void Main(string[] args)
            {
                double xn = -7;
                double xk = 3;
                int n = 20;
                double dx = -(xn - xk) / n;
                for (double x = xn; x < xk + 0.1; x += dx)
                {
                    Console.WriteLine("x = {0:F2}, y = {1:F2} ", x, f(x));
                }
            }


        }


        }
    }

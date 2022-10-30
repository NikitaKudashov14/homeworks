using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lesson
{
    class MyClass
    {
        public static int[] AddElements(int N)
        {
            Random random = new Random();
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            return arr;
        }

        public static int SumIntElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int ProizvIntElements(int[] arr)
        {
            int mult = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                mult *= arr[i];
            }
            return mult;
        }

        public static string MaxValueIntElements(int[] arr)
        {
            int tmp = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (tmp < arr[i])
                {
                    tmp = arr[i];
                    index = i;
                }
            }
            return $"{tmp} position = {index + 1}";
        }

        public static int SumDoubleElements(double[] arr)
        {
            double sum = Convert.ToDouble(arr.Sum());
            return (int) sum;
        }

        public static int ProizvDoubleElements(double[] arr)
        {
            double mult = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                mult = Convert.ToDouble(arr[i]);   
                mult *= arr[i];
            }
            return (int) mult;
        }

        public static string MaxValueDoubleElements(double[] arr)
        {
            double tmp = Convert.ToDouble(arr[0]);
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (tmp < Convert.ToDouble(arr[i]))
                {
                    tmp = Convert.ToDouble(arr[i]);
                    index = i;
                }
            }
            return $"{tmp} position = {index + 1}";
        }

        public static double[] DoubleArray(int N)
        {
            Random random = new Random();
            double[] arr = new double[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.NextDouble();
            }
            return arr;
        }

        public static int[,] MatrixArray(int N)
        {
            Random random = new Random();
            int[,] arr = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = random.Next(1, 10);
                }
            }
            return arr;
        }

        public static double[,] DoubleMatrix(int N)
        {
            Random random = new Random();
            double[,] arr = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = random.NextDouble();
                }
            }
            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;

            Console.WriteLine("AddElements:");
            int[] tmp = MyClass.AddElements(N);

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", tmp[i]);
            }


            Console.WriteLine();
            Console.WriteLine("Sum {0}| Proizv {1}| MaxValue {2}", MyClass.SumIntElements(tmp), MyClass.ProizvIntElements(tmp), MyClass.MaxValueIntElements(tmp));
            Console.WriteLine("Double array:");
            double[] arr2 = MyClass.DoubleArray(N);

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0:0.##} ", MyClass.DoubleArray(N)[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Sum {0}| Proizv {1}| MaxValue {2}", MyClass.SumDoubleElements(arr2), MyClass.ProizvDoubleElements(arr2), MyClass.MaxValueDoubleElements(arr2));






        }
    }
}


//




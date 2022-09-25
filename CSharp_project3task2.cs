using System;
using System.Globalization;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { -3, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int result = 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        result *= array[i, j];
                    }
                    else
                    {
                        result = 0;
                        break;
                    }
                }
                Console.Write(result + " ");
            }
            Console.ReadKey(true);

        }
    }
}

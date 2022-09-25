using System;
using System.Globalization;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {3, 6, 5 },
                {4, 7, -2 },
                {2, 8, 4 }

            };

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int[] new_arr1 = new int[width];
            int[] new_arr2 = new int[width];
            int[] new_arr3 = new int[width];


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j <= 2)
                    {
                        for (int a = 0; a < width; a++)
                        {
                            new_arr1[a] = matrix[i, j];
                        }
                    } else if (i == 1 && j <= 2)
                    {
                        for (int b = 0; b < width; b++)
                        {
                            new_arr2[b] = matrix[i, j];
                        } 
                    } else if (i == 2 && j <= 2)
                    {
                        for (int c = 0; c < width; c++)
                        {
                            new_arr3[c] = matrix[i, j];
                        }
                    }
                }
            }

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int a1 = 0; a1 < new_arr1.Length; a1++)
            {
                if (new_arr1[a1] > 0)
                {
                    sum1 += new_arr1[a1];
                } else
                {
                    sum1 = 0;
                    break;
                }
            }

            for (int a2 = 0; a2 < new_arr2.Length; a2++)
            {
                if (new_arr2[a2] > 0)
                {
                    sum2 += new_arr2[a2];
                }
                else
                {
                    sum2 = 0;
                    break;
                }
            }

            for (int a3= 0; a3 < new_arr3.Length; a3++)
            {
                if (new_arr3[a3] > 0)
                {
                    sum3 += new_arr3[a3];
                }
                else
                {
                    sum3 = 0;
                    break;
                }
            }

            Console.WriteLine(sum1 + "," + sum2 + "," + sum3);

        }


    }
}

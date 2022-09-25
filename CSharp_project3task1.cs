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
            // пункт 1 
            int N = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            int sum = 0; 

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент под номером {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
                if ((i + 1) % 2 != 0)
                {
                    sum += myArray[i];
                }
            }

            Console.WriteLine(sum);

            //пункт 2 
            int firstChPosition = Array.FindIndex(myArray, i => i < 0) + 1;
            int lastChPosition = Array.FindLastIndex(myArray, i => i < 0);
            int sum_nechet = 0;

            for (int j = firstChPosition; j < lastChPosition; j++)
            {
                sum_nechet += myArray[j];
            }

            Console.WriteLine(sum_nechet);

            //пункт 3 
            for (int a = 0; a < myArray.Length; a++)
            {
                Console.Write($"{myArray[a]} ");
            }
     
        }


        }
    }
          

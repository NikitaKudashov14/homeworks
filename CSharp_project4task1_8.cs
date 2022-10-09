using System;
using System.Collections.Generic;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 задание 
            Console.WriteLine("1 задание");
            List<int> numbers = new List<int>() { 12, 25, 69, 87, 94 };
            
            foreach (int item1 in numbers)
            {
                Console.Write(item1+" | ");
            }
            Console.Write("Введите свое число: ");
            int user_ch = int.Parse(Console.ReadLine());
            numbers.Add(user_ch);

            foreach (int item2 in numbers)
            {
                Console.Write(item2+ " | ");
            }

            Console.WriteLine();
            // 2 задание
            Console.WriteLine("2 задание");
            List<int> numbers2 = new List<int>() { 16, 25, 30 };
            
            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.Write(numbers2[i] + " - ");
            }

            Console.WriteLine();

            //3 задание 
            Console.WriteLine("3 задание");
            foreach (int item3 in numbers2)
            {
                int position = 2;
                numbers.Insert(position, item3);
                position++;
            }

            for (int j = 0; j<numbers.Count; j++)
            {
                Console.Write(numbers[j] + " | ");
            }
            Console.WriteLine();
            //4 задание
            Console.WriteLine("4 задание");
            Console.WriteLine("Количество элементов в 1 списке: "+ numbers.Count);
            //5 задание 
            Console.WriteLine("5 задание");
            Console.WriteLine("Максимальный элемент 1 списка : " + numbers.Max(point => point));
            //6 задание 
            Console.WriteLine("6 задание");
            Console.WriteLine("Минимальный элемент 1 списка : " + numbers.Min(point => point));
            //7 задание 
            Console.WriteLine();
            Console.WriteLine("7 задание");
            int[] myArr = new int[numbers2.Count];
            numbers2.CopyTo(0, myArr, 0, numbers2.Count);

            foreach (int t in myArr)
            {
                Console.Write(t + " | ");
            }

            //8 задание 
            Console.WriteLine();
            Console.WriteLine("8 задание");
            numbers2.RemoveAt(1);
            foreach (int x in numbers2)
            {
                Console.Write(x + " | ");
            }


        }
    }
}


    

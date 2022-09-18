using System;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
        
            for (int i = 10; i < 100; i++)
            {
                int x = i * i;
                if (i <= 31)
                {
                    int first_c = x / 100;
                    int second_c = (x % 100) / 10;
                    int third_c = (x  % 10);
                    if (first_c == third_c)
                    {
                        Console.WriteLine(i + "дает число палиндром: " + x);
                    }
                } else if (i > 31) 
                {
                    int first_c = x  / 1000;
                    int second_c = (x % 1000) / 100;
                    int third_c = (x % 100) / 10;
                    int fourth_c = x % 10;
                    if (first_c == fourth_c && second_c == third_c)
                    {
                        Console.WriteLine(i + "дает число палиндром: " + x);
                    }
                }
            }


        }
    }
}
            

using System;
using System.Linq;
using System.Collections;

namespace ConsoleApp1
{
    public class Set
    {
        public int[] Elements = new int[0];
        private int count;
        public int Count
        {
            set
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Ошибка введения!");
                }
                else
                {
                    count = value;
                    Array.Resize<int>(ref Elements, count);

                }
            }
            get
            {
                return count;
            }
        }

        public Set()
        {
            Console.Write("Введите количество элементов множества: ");
            Count = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Fill();
        }

        public Set(int[] array)
        {
            this.Elements=array;
        }

        public void Fill()  //вводим элементы множества
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.Write($"Введите значение элемента №{i + 1}: ");
                this.Elements[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public int IndexOf(int value)  //сравниваем элемент множества со строкой
        {
            int tempIndex = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (Elements.Equals(value))
                {
                    tempIndex = i;
                    break;
                }
               
            }
            return tempIndex;
        }

        public void ShowSet() //выводим множество
        {
            Console.Write("\nМножество: ");
            foreach (var item in Elements)
            {
                Console.Write($"{item} ");
            }
        }

        public void Add(int newElement)
        {
            Array.Resize<int>(ref Elements, Elements.Length + 1);
            Elements[Elements.Length - 1] = newElement;
            count = Elements.Length;
        }

        public static Set operator ++(Set set1)
        {
            for (int i = 0; i < set1.Elements.Length; i++)
            {
                set1.Elements[i]++;
            }
            return set1;
        }

        public static Set operator +(Set set1, Set set2) // Объединение множеств.
        {
            Set tempArray = new Set(set1.Elements);

            
           for (int i =0;i<set2.Elements.Length;i++)
           {
               tempArray.Add(set2[i]);
               
           }
            
            return tempArray;
        }

        public static Set operator *(Set set1, Set set2)  //умножение 
        {
        
            Set tempArray = new Set(new int[0]);
            
            for (int i = 0; i < set1.Elements.Length; i++) {
                for (int j = 0; j < set2.Elements.Length; j++){
                    if (set1.Elements[i] == set2.Elements[j]) {
                        tempArray.Add(set1.Elements[i]);
                    }
                }
            }
            
            return tempArray;
            
        }

        public static Set operator /(Set set1, Set set2)  //деление
        {
            Set tempArray = new Set(new int[0]);
            
            for (int i = 0; i < set1.Elements.Length; i++) {
                    if (set1.Elements[i] != set2.Elements[i]) {
                        tempArray.Add(set1.Elements[i]);
                    }
                }
            
            return tempArray;
        }

        public static bool operator <(Set set1, Set set2)  //сравнение
        {
            if (set1.Elements.Length < set2.Elements.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Set set1, Set set2)
        {
            if (set1.Elements.Length > set2.Elements.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int this[int index] // Индексатор.
        {
            get
            {
                return Elements[index];
            }
            set
            {
                Elements[index] = value;
            }
        }
    }
    class lesson
    {
        public static void Main(string[] args) {
            int[] myarr = new int[3] { 12, 16, 22 };
            Set s1 = new Set();
            s1.ShowSet();
            Set s2 = new Set(myarr);
            s2.ShowSet();

            // bool result = s1 > s2;
            // s1.Add(8);
            // s1.ShowSet();
            // Console.WriteLine(result);
            // int[] plus = s1+s2;
            Set s = s1+s2;
            s.ShowSet();
            // for (int i = 0; i < s.Length; i++) {
            //     Console.Write(s[i]);
            // }
            Set s4=s1*s2;
            s4.ShowSet();
            Set s5=s1/s2;
            s5.ShowSet();
            
        }
    }
}

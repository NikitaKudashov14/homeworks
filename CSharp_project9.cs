using System;

namespace ConsoleApp1
{
    public class Set
    {
        public int[] Elements;
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
            Array.Copy(array, Elements, count);
        }

        public void Fill()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.Write($"Введите значение элемента №{i + 1}: ");
                this.Elements[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public int IndexOf(int value)
        {
            int tempIndex = 0;

            for (int i = 0; i < this.Count; i++)
            {
                if (Elements.Equals(value))
                {
                    tempIndex = i;
                    break;
                }
                else
                {
                    tempIndex = -1;
                }
            }
            return tempIndex;
        }

        public void ShowSet()
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
            Elements[Elements.Length + 1] = newElement;
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
            int[] tempArray = new int[set1.Elements.Length + set2.Elements.Length];

            int i = 0, j = 0, n = 0;
            while ((i < set1.Elements.Length) && (j < set2.Elements.Length))
            {
                if (set1.Elements[i] < set2.Elements[j])
                {
                    tempArray[n++] = set1.Elements[i++];
                }
                else if (set2.Elements[j] < set1.Elements[i])
                {
                    tempArray[n++] = set2.Elements[j++];
                }
                else
                {
                    tempArray[n++] = set1.Elements[i++];
                    ++j;
                }
            }

            while (i < set1.Elements.Length)
            {
                tempArray[n++] = set1.Elements[i++];
            }

            while (j < set2.Elements.Length)
            {
                tempArray[n++] = set2.Elements[j++];
            }

            return new Set(tempArray);
        }

        public static Set operator *(Set set1, Set set2) //Пересечение множеств. ПОД ВОПРОСОМ!!!
        {
            int[] tempArray = new int[set1.Elements.Length + set2.Elements.Length];

            int d = 0;

            for (int i = 0; i < set1.Elements.Length; i++)
            {
                int j = 0, k = 0;
                while (j < set2.Elements.Length && set2.Elements[j] != set1.Elements[i])
                {
                    j++;
                }

                while (k < d && tempArray[k] != set1.Elements[i])
                {
                    k++;
                }

                if (j != set2.Elements.Length && k == d)
                {
                    tempArray[d++] = set1.Elements[i];
                }
            }

            return new Set(tempArray);
        }

        public static Set operator /(Set set1, Set set2) //Разность множеств.
        {
            int[] tempArray = new int[set1.Elements.Length + set2.Elements.Length];

            for (int i = 0; i < set1.Elements.Length; i++)
            {
                int j = 0;
                while (j < set2.Elements.Length && set2.Elements[j] != set1.Elements[i])
                {
                    j++;
                }

                if (j == set2.Elements.Length)
                {
                    tempArray[i] = set1.Elements[i];
                }
            }

            return new Set(tempArray);
        }

        public static bool operator <(Set set1, Set set2)
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
}

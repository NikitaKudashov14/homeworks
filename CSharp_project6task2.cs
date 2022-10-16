using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lesson 
{
    class Program
    {

        static string[] first_arr;
        static string[] final_arr;

        static string path1 = @"C:\Users\Никита\OneDrive\Рабочий стол\2.txt"; //путь к файлу для чтения
        static string path2 = @"C:\Users\Никита\OneDrive\Рабочий стол\3.txt"; //путь к файлу для записи результата

        static string[] linesR; //массив строк читаемого файла
        static List<string> result = new List<string>();
        static StreamWriter writer;
        static void Main(string[] args)
        {
            first_arr = args;
            if (path1 == null & !(first_arr.Length > 0))
            {
                Console.WriteLine("Введите путь к вашему файлу");
                path1 = Console.ReadLine();
            }
            else if (path1 == null & (first_arr.Length > 0))
            {
                path1 = first_arr[0];
            }
            try
            {
                linesR = new string[File.ReadAllLines(path1).Length];


                linesR = File.ReadAllLines(path1, Encoding.Default);

            }
            catch { Console.WriteLine("Неверный путь к файлу. Повторите попытку"); enterpath(ref path1); }
            for (int i = 0; i < linesR.Length; i++)
            {
                if (linesR[i].Contains("специальность"))
                {
                    vrach.vrach_list.Add(new vrach(linesR[i].Remove(0, linesR[i].IndexOf("специальность") + 13).Trim()));
                }
            }

            foreach (var a in vrach.vrach_list)
            {
                if (result.All(n => n != a.spec))
                {
                    result.Add(a.spec);
                    spec.list.Add(new spec(1, a.spec));
                }
                else
                {
                    for (int i = 0; i < spec.list.Count; i++)
                    {
                        if (spec.list[i].name == a.spec)
                            spec.list[i].count++;
                    }
                }
            }
            final_arr = new string[spec.list.Count];//конечный массив для записи
            for (int i = 0; i < spec.list.Count; i++)
            {
                final_arr[i] = "специальность " + spec.list[i].name + " кол-во " + spec.list[i].count;
            }
            ready();
        }


        static void ready()
        {
            Console.WriteLine("Готово");
            if (path2 == null)
            {
                Console.WriteLine("Введите путь для сохранения");
                path2 = Console.ReadLine();
                try
                {
                    File.WriteAllLines(path2, final_arr, Encoding.Default);
                }
                catch
                {
                    Console.WriteLine("Не найден файл для вывода");
                    enterpath(ref path2);
                    ready();
                }
            }
            else
            {
                try
                {
                    File.WriteAllLines(path2, final_arr, Encoding.Default);
                }
                catch
                {
                    Console.WriteLine("Не найден файл для вывода");
                    enterpath(ref path2);
                    ready();
                }
            }

        }




        static void enterpath(ref string str)
        {
            Console.WriteLine("Введите путь к текстовому файлу");
            str = Console.ReadLine();
            Main(first_arr);
        }
    }
    class vrach
    {
        public static List<vrach> vrach_list = new List<vrach>();

        public string spec;
        public vrach(string spec)
        {
            this.spec = spec;
        }
    }

    class spec
    {
        public static List<spec> list = new List<spec>();

        public string name;
        public int count;
        public spec(int c, string name)
        {
            count = c;
            this.name = name;
        }
    }
}
//




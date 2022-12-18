using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ConsoleApp13
{
    
    class Athlete
    {
        public string Surname { get; set; }
        public string Sport { get; set; }
        public int Position { get; set; }
        public string Medal { get ; set; }
        public Athlete(string surname, string sport, int position, string medal)
        {
            Surname = surname;
            Sport = sport;
            Position = position;
            Medal = medal;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Athlete> users = new List<Athlete>
            {
                new Athlete("Ronaldo", "Football", 1, "Gold"),
                new Athlete("Messi", "Football", 1, "Gold"),
                new Athlete("Radulov", "Hockey", 2, "Silver"),
                new Athlete("Shipachyov", "Hockey", 3, "Bronze"),
                new Athlete("Panarin", "Hockey", 4, "No"),
                new Athlete("Kaprizov", "Hockey", 3,"Bronze"),
                new Athlete("Medvedev", "Tennis", 1, "Gold"),
                new Athlete("McDavid", "Hockey", 1, "Gold"),
                new Athlete("Dzyuba", "Football", 151, "No"),
                new Athlete("Zagitova", "Figure Skating", 1, "Gold"),
                new Athlete("Medvedeva", "Figure Skating", 2, "Silver"),
                new Athlete("Smolov", "Football", 152, "No"),
                new Athlete("Sharapova", "Tennis", 1, "Gold"),
                new Athlete("James", "Basketball", 1, "Gold"),
                new Athlete("Brayant", "Basketball", 2, "Silver"),
                new Athlete("Kovalchuk", "Hockey", 4, "No"),
                new Athlete("Alexeyev", "Hockey", 3, "Bronze")
            };

            Console.WriteLine("Фильтрация");
            var filter_result = from user in users
                                where user.Position < 4
                                where user.Sport == "Hockey" || user.Sport == "Football"
                                select user;
            foreach (var item in filter_result)
            {
                Console.WriteLine($"Фамилия: {item.Surname} Вид спорта: {item.Sport} Место: {item.Position}");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Проекция");
            var pr = from user in users
                     where user.Position < 4
                     select new
                     {
                         Surname = user.Surname,
                         Medal = user.Medal

                     };
           foreach (var item in pr)
            {
                Console.WriteLine($"Фамилия: {item.Surname} Медаль: {item.Medal}");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Сортировка по фамилии");
            var sort = from user in users
                       orderby user.Surname
                       select user;

            foreach(var item in sort)
            {
                Console.WriteLine($"Фамилия: {item.Surname}");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Сортировка по месту");
            var sort2 = from user in users
                       orderby user.Position ascending
                       select user;

            foreach (var item in sort2)
            {
                Console.WriteLine($"Фамилия: {item.Surname} Место: {item.Position}");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Группировка");

            var group = from user in users
                        group user by user.Sport;

            foreach(var sport in group)
            {
                Console.WriteLine(sport.Key);
                foreach(var player in sport)
                {
                    Console.WriteLine(player.Surname);
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Агрегатные функции");

            var user_for_gl = from user in users
                              where user.Surname.StartsWith("A") || user.Surname.StartsWith("E") || user.Surname.StartsWith("I") || user.Surname.StartsWith("O") || user.Surname.StartsWith("U") || user.Surname.StartsWith("Y")
                              select user;

            foreach(var item in user_for_gl)
            {
                Console.WriteLine($"Фамилия: {item.Surname}");
            }




        }




    }
}

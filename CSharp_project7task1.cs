using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lesson
{
    class Student
    {
        public string Surname;
        public string Speciality;
        public int Form;
        
        public Student() { }
        public Student(string surname, string speciality, int form)
        {
            Surname = surname;
            Speciality = speciality;
            Form = form;
        }

        public void say_info()
        {
            Console.WriteLine($"Surname: {Surname} | Speciality:{Speciality} | Form:{Form}");
        }

        public void update_info()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Kudashov = new Student();
            Student Marinina = new Student("Marinina", "Information security", 1);
            Kudashov.say_info();
            Marinina.say_info();
            string info = $"Surname: {Marinina.Surname} Speciality: {Marinina.Speciality} Form:{Marinina.Form}";

            string path = @"C: \Users\Никита\OneDrive\Рабочий стол\1.txt";
            File.WriteAllText(path, info);
        }

    } 
}

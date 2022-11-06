using System;
using System.IO;

namespace lesson { 
    class Student
    {
        private string surname;
        private string speciality;
        private int form;

        public static Student operator +(Student Marinina, Student Girfanov)
        {
            return new Student { Form = Marinina.Form + Girfanov.Form };
        }

        public static bool operator >(Student Marinina, Student Girfanov)
        {
            return Marinina.Form > Girfanov.Form;
        }
        public static bool operator <(Student Marinina, Student Girfanov)
        {
            return Marinina.Form < Girfanov.Form;
        }
        public int Form
        {
            set
            {
                form = value;
                Console.WriteLine("Значение form изменено");
            }

            get
            {
                return form;
            }
        }

        public Student() { }
        public Student(string surname, string speciality, int form)
        {
            this.surname = surname; 
            this.speciality = speciality;
            this.form = form;
            
        }

        public Student(Student student)
        {
            this.surname = student.surname;
            this.speciality = student.speciality;
            this.form = student.form;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Surname : {surname} | Speciality: {speciality} | Form: {form}");
        }

        public void UpdateInfo(string new_speciality)
        {
            Console.WriteLine("New info for Speciality");
            speciality = new_speciality;
            Console.WriteLine($"Data is updated! New speciality: {speciality}");
        }

        public void SaveInfo()
        {
            string path = @"C:\Users\Никита\OneDrive\Рабочий стол\library.txt";
            string data = $"Surname : {surname} | Speciality: {speciality} | Form: {form}";
            File.WriteAllText(path, data);
        }
        
    }

    class Program3
    {
        public static void Main(string[] args)
        {
            Student Kudashov = new Student();
            Student Marinina = new Student("Marinina", "Information security", 1);

            Kudashov.PrintInfo();
            Marinina.PrintInfo();
            Marinina.UpdateInfo("Economist");
            Marinina.PrintInfo();
            Marinina.SaveInfo();

            Student Girfanov = Marinina;
            int all_course = Marinina + 2;
        }
    }
}

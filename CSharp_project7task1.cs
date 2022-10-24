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
        public int form = 0;
        public string path1 = $"1.docx";
        public int Form {
            set {
                Console.WriteLine("Процесс изменения данных");
                if (value < 0 || value > 6) {
                    Console.WriteLine("Ошибка");
                } else {
                    form = value; 
                }
            }
            
            get {
                Console.WriteLine("Процесс передачи данных");
                return form;
            }
        }
        
        public Student() { }
        public Student(string surname, string speciality)
        {
            Surname = surname;
            Speciality = speciality;
            Form = form;
            
        }
        

        public void say_info()
        {
            Console.WriteLine($"Surname: {Surname} | Speciality:{Speciality} | Form:{Form}");
        }
        
        public void delete_data() {
            File.WriteAllText(path1, "");
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Kudashov = new Student();
            Student Marinina = new Student("Marinina", "Information security");
            Marinina.Form = 1;
            Kudashov.say_info();
            Marinina.say_info();
            Console.WriteLine(Marinina.Form);
            string path = $"1.docx";
            string info = $"Surname: {Marinina.Surname} Speciality: {Marinina.Speciality} Form:{Marinina.Form}";
            
            string user_input = Console.ReadLine();
            if (user_input == "Save Data") {
                File.WriteAllText(path, info);
            } else if (user_input == "Delete Data") {
                Marinina.delete_data();
            }
            
        
            
            
            
        }

    } 
     
}

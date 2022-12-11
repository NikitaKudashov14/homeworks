using System;
using System.Globalization;
using System.IO;

namespace ConsoleApp13
{
    class Car
    {
        public int _speed = 30;
        public string _name;
        public string _number;
        public string _car_driver_fullname;
        public Car(string name, string number, string cardriver)
        {
            _name = name;
            _number = number;
            _car_driver_fullname = cardriver;
        }
    }

    class Camera
    {
        public delegate void SpeedCallBack(string message);
        public event SpeedCallBack Notify;
        public string Message = "Полный порядок. Скорость не превышена!";
        public void Speed_Check(string area, Car car)
        {
            if (area == "Двор")
            {
                if (car._speed <= 20)
                {
                    Console.WriteLine("Полный порядок. Скорость не превышена!");
                } else if (car._speed > 20)
                {
                    Notify($"Скорость была превышена на {car._speed - 20} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}");
                    Message = $"Скорость была превышена на {car._speed - 20} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}";
                }
            } else if (area == "Населенный пункт")
            {
                if (car._speed <= 60)
                {
                    Console.WriteLine("Полный порядок. Скорость не превышена!");
                }
                else if (car._speed > 60 && car._speed < 80)
                {
                    Console.WriteLine("Порядок. В населенных пунктах разрешена скорость 60+-20 км/ч");
                } else if (car._speed > 80)
                {
                    Notify($"Скорость была превышена на {car._speed - 80} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}");
                    Message = $"Скорость была превышена на {car._speed - 80} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}";
                }
            } else if (area == "Автомагистраль")
            {
                if (car._speed < 40)
                {
                    Notify($"Тихоходным ТС запрещено передвигаться по автомагистралям. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}");
                    Message = $"Тихоходным ТС запрещено передвигаться по автомагистралям. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}";
                } else if (car._speed > 40 && car._speed < 110)
                {
                    Console.WriteLine("Полный порядок! Скорость не превышена.");
                } else if (car._speed > 110)
                {
                    Notify($"Скорость была превышена на {car._speed - 110} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}");
                    Message = $"Скорость была превышена на {car._speed - 110} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}";
                }
            }
        }
    }

    class GIBDD 
    {
        string path = @"C:\Users\Никита\OneDrive\Рабочий стол\GIBDD_database.txt";
        
        public void TrafficFine(Camera camera)
        {
            File.AppendAllText(path, camera.Message);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota Camry", "A887AA", "Marinina Anna Vyacheslavovna");
            Car car2 = new Car("Mercedes Benz C-class", "M777OC", "Girfanov Ranil Raisovich");
            Car car3 = new Car("Toyota Highlander", "K014HO", "Kudashov Nikita Olegovich");
            Camera main_camera = new Camera();
            GIBDD gibdd = new GIBDD();
            main_camera.Notify += TextMessage;
            car1._speed = 85;
            car2._speed = 100;
            car3._speed = 130;
            main_camera.Speed_Check("Населенный пункт", car1);
            main_camera.Speed_Check("Автомагистраль", car2);
            main_camera.Speed_Check("Автомагистраль", car3);
            gibdd.TrafficFine(main_camera);
            gibdd.TrafficFine(main_camera);

        }

        static void TextMessage(string message)
        {
            Console.WriteLine(message);
        }

        
    }
}

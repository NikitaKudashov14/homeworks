using System;
using System.Globalization;

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
                }
            } else if (area == "Автомагистраль")
            {
                if (car._speed < 40)
                {
                    Notify($"Тихоходным ТС запрещено передвигаться по автомагистралям. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}");
                } else if (car._speed > 40 && car._speed < 110)
                {
                    Console.WriteLine("Полный порядок! Скорость не превышена.");
                } else if (car._speed > 110)
                {
                    Notify($"Скорость была превышена на {car._speed - 110} км/ч. Скорость авто на момент нарушения: {car._speed}. Марка авто: {car._name}, гос. номер: {car._number}, ФИО водителя: {car._car_driver_fullname}");
                }
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota Camry", "A887AA", "Marinina Anna Vyacheslavovna");
            Camera main_camera = new Camera();
            main_camera.Notify += TextMessage;
            car1._speed = 85;
            main_camera.Speed_Check("Населенный пункт", car1);

        }

        static void TextMessage(string message)
        {
            Console.WriteLine(message);
        }

        
    }
}

using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;


namespace laba12
{
    abstract class Printed_edition
    {
        public string Printed_edition1 { get; set; }


        public Printed_edition(string printed_edition1)
        {
            Printed_edition1 = printed_edition1;
        }
    }
    class Airplane : Printed_edition, ICloneable
    {
        public Airplane(string printed_edition1)
            : base(printed_edition1) { }

        public object Clone() => MemberwiseClone();//поверхностное копирование
    }

    class Train : Printed_edition, ICloneable
    {
        public int Speed { get; set; }
        public Company Name{ get; set; }
        public Train(string printed_edition1, int speed, Company company)
            : base(printed_edition1)
        {
            Speed = speed;
            Name = company;
        }
        public object Clone() => new Train(Printed_edition1, Speed, new Company(Name.Name));
        //Глубокое копирование
    }
    class Company
    {
        public string Name { get; set; }
        public Company(string name) => Name = name;
    }


    class Car : Printed_edition, IComparable//сравнение при помощи Icomparable
    {
        public int Speed { get; set; }
        public Car(string printed_edition1, int speed)
            : base(printed_edition1)
        {
            Speed = speed;
        }
        public int CompareTo(object? o)
        {
            if (o is Car car) return Speed.CompareTo(car.Speed);
            else throw new ArgumentException("Incorrect paramethr");
        }
    }
    class TrainComparer : IComparer<Train>//сортировка компаратором
    {
        public int Compare(Train? train1, Train? train2)
        {
            if (train1.Speed < train2.Speed)
                return -1;

            else if (train1.Speed > train2.Speed)
                return 1;

            else
                return 0;
        }
    }
    class Cars : IEnumerable
    {
        string[] cars = {  "Mercedes",
                                "BMW",
                                "MClaren",
                                "Ferrari"   };
        public IEnumerator GetEnumerator() => cars.GetEnumerator();
    }
    class Transport_store
    {
        static void Main(string[] args)
        {
            var airplane1 = new Airplane("Airbus A321");

            var airplane2 = (Airplane)airplane1.Clone();

            airplane2.Printed_edition1 = "Boeing 747-800";

            Console.WriteLine("( ICloneable superfically copy):");


            Console.WriteLine(airplane1.Printed_edition1);

            Console.WriteLine("-----------------------");

            var train1 = new Train("Lokomitiv",180,  new Company("RZHD"));

            var train2 = (Train)train1.Clone();

            var train3 = new Train("Sapsan", 480, new Company("RZHD"));

            var train4 = new Train("Maglev", 500000, new Company("China"));

            Train[] trains = { train1, train3, train4 };

            train2.Name.Name = "RZHD";

            Console.WriteLine("DEEP COPY:");


            Console.WriteLine(train1.Name.Name);

            Console.WriteLine("-----------------------");

            var car1 = new Car("Toyota Camry", 230);

            var car2 = new Car("LADA Granta", 200);

            var car3 = new Car("BUKHANKA", 500);

            Car[] cars = { car1, car2, car3 };

            Array.Sort(cars);

            Console.WriteLine(" IComparable:");


            foreach (Car car in cars)
            {

                Console.WriteLine($"{car.Printed_edition1} - {car.Speed}");

            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("IComparer:");

            Array.Sort(trains, new TrainComparer());

            foreach (Train train in trains)
            {

                Console.WriteLine($"{train.Printed_edition1} - {train.Speed}");

            }

            Console.WriteLine("-----------------------");

            Cars CARS = new Cars();

            Console.WriteLine(" IEnumerable:");


            foreach (var cArs in CARS)
            {

                Console.WriteLine(cArs);

            }
        }
    }
}

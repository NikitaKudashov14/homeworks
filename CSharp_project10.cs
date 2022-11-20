using System;
using System.IO;
namespace classes_c_
{
    public class Product
    {
        private string name;
        private string code;
        private int count;
        public Product()
        {
            name = "VODKA";
            code = "5655";
            count = 0;
        }
        public Product(string name, string code, int count)
        {
            Name = name;
            Code = code;
            Count = count;
        }


        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0)
                {
                    count = value;
                }
                else
                {
                    throw new Exception("Can`t be negative value");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Can`t be empty Name");
                }
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (value != "")
                {
                    code = value;
                }
                else
                {
                    throw new Exception("Can`t be empty Code");
                }
            }
        }

        public override string ToString() => $"{name} - {code} - {count}";

        public static Product operator +(Product prod1, Product prod2)
        {
            return new Product(prod1.Name + "/" + prod2.Name, prod1.Code + "/" + prod2.Code, prod1.Count + prod2.Count);
        }

        public static bool operator >(Product prod1, Product prod2)
        {
            return prod1.Count > prod2.Count;
        }
        public static bool operator <(Product prod1, Product prod2)
        {
            return prod1.Count < prod2.Count;
        }
        public void ToFile()
        {
            using (StreamWriter sw = new StreamWriter("result.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(this.ToString());
                sw?.Close();
            }

        }

    }

    public class Food : Product
    {
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {

                if (value >= 0)
                {
                    energy = value;
                }
                else
                {
                    throw new Exception("Can`t be negative value");
                }
            }
        }
        public Food() : base()
        {

            Energy = 200;
        }

        public Food(string name, string code, int count, int energy) : base(name, code, count)
        {
            Energy = energy;
        }

        public override string ToString()
        {
            return $"{Name} - {Code} -{Energy} - {Count}";
        }

    }

    public class Drink : Product
    {
        public string Color { get; set; }
        public Drink() : base()
        {

            Color = "transparent";
        }

        public Drink(string name, string code, int count, string color) : base(name, code, count)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"{Name} - {Code} -{Color} - {Count}";
        }

    }

    public class HouseholdСhemicals : Product
    {

        public bool IsToxic { get; set; }
        public HouseholdСhemicals() : base()
        {

            IsToxic = true;
        }

        public HouseholdСhemicals(string name, string code, int count, bool isToxic) : base(name, code, count)
        {
            IsToxic = isToxic;
        }

        public override string ToString()
        {
            return $"{Name} - {Code} -{IsToxic} - {Count}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var products = new Product[5]{
                new Drink(),
                new HouseholdСhemicals("Fairy","FAIRY23",5,false),
                new Food("Big Mak","BM2018",5,500),
                new Food("Snikers","CHOCKOLATE12",10,250),
                new Drink("Cola","ZEROCOLA",6,"BLACK")
            };
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}

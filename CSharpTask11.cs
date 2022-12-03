using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
abstract class Transport
{
    public abstract string Name { get; set; }
    public abstract int Speed { get; set; }

}

class Car : Transport
{
    int speed;
    string name;
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public override int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}

class Train : Transport
{
    int speed;
    string name;
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public override int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}

class Airplane : Transport
{
    int speed;
    string name;
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public override int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}

class TransportCompany
{
    List<Transport> list = new List<Transport>();
    public void AddElement(Transport t)
    {
        list.Add(t);
    }

    public void RemoveElement(int t)
    {
        list.RemoveAt(t);
    }

    public void UpdateElement(Transport t, int index)
    {

        list[index] = t;

    }

    public void Data()
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        if (list.Count == 0)
        {
            Console.WriteLine("Ошибка!");
        }
    }

}
class HelloWorld
{
    static void Main()
    {
        int input = 0;
        TransportCompany t1 = new TransportCompany();
        Console.WriteLine("Выберите действие. 1 - добавить элемент. 2 - удалить элемент. 3 - изменить элемент. 4 - вывести информацию. 5 - выход из программы");
        while (input != 5)
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Что именно нужно добавить? Машину, самолет или поезд?");
                string choice = Console.ReadLine();
                if (choice == "Машину")
                {
                    t1.AddElement(new Car());
                } else if (choice == "Самолет")
                {
                    t1.AddElement(new Airplane());
                } else if (choice == "Поезд")
                {
                    t1.AddElement(new Train());
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Выберите индекс элемента, который нужно удалить");
                int position = Convert.ToInt32(Console.ReadLine());
                t1.RemoveElement(position);
            }
            else if (input == 3)
            {
                Console.WriteLine("Выберите позицию, которую нужно заменить и новый элемент(самолет, поезд или машина)");
                int pos = Convert.ToInt32(Console.ReadLine());
                string ch= Console.ReadLine();
                if (ch == "Машина")
                {
                    t1.UpdateElement(new Car(), pos);
                } else if (ch == "Поезд")
                {
                    t1.UpdateElement(new Train(), pos);
                } else if (ch == "Самолет")
                {
                    t1.UpdateElement(new Airplane(), pos);
                }

            }
            else if (input == 4)
            {
                t1.Data();
            }
            else if (input == 5)
            {
                break;
            }


        }

    }
}

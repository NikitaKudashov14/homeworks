using System.Xml.Linq;
using System;
using System.Collections;

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
    class Magazine : Printed_edition, ICloneable
    {
        public Magazine(string printed_edition1)
            : base(printed_edition1) { }

        public object Clone() => MemberwiseClone();//поверхностное копирование
    }

    class Book : Printed_edition, ICloneable
    {
        public int PapersCount { get; set; }
        public Author Name { get; set; }
        public Book(string printed_edition1, int paperscount, Author author)
            : base(printed_edition1)
        {
            PapersCount = paperscount;
            Name = author;
        }
        public object Clone() => new Book(Printed_edition1, PapersCount, new Author(Name.Name));
        //Глубокое копирование
    }
    class Author
    {
        public string Name { get; set; }
        public Author(string name) => Name = name;
    }


    class News_paper : Printed_edition, IComparable//сравнение при помощи Icomparable
    {
        public int Cost { get; set; }
        public News_paper(string printed_edition1, int cost)
            : base(printed_edition1)
        {
            Cost = cost;
        }
        public int CompareTo(object? o)
        {
            if (o is News_paper news_papers) return Cost.CompareTo(news_papers.Cost);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
    class BooksComparer : IComparer<Book>//сортировка компаратором
    {
        public int Compare(Book? book1, Book? book2)
        {
            if (book1.PapersCount < book2.PapersCount)
                return -1;

            else if (book1.PapersCount > book2.PapersCount)
                return 1;

            else
                return 0;
        }
    }
    class Magazines : IEnumerable
    {
        string[] magazines = {  "Time",
                                "PSYCHOLOGIES",
                                "ELLE GIRL",
                                "FORBES"   };
        public IEnumerator GetEnumerator() => magazines.GetEnumerator();
    }
    class Book_store
    {
        static void Main(string[] args)
        {
            var magazine1 = new Magazine("5 КОЛЕСО");

            var magazine2 = (Magazine)magazine1.Clone();

            magazine2.Printed_edition1 = "SALON-INTERIOR";

            Console.WriteLine("Реализация ICloneable(поверхностно копирование):");


            Console.WriteLine(magazine1.Printed_edition1);

            Console.WriteLine("-----------------------");

            var book1 = new Book("Война и мир", 500, new Author("Л.Н.Толстой"));

            var book2 = (Book)book1.Clone();

            var book3 = new Book("Евгений Онегин", 180, new Author("А.С.Пушкин"));

            var book4 = new Book("Поднятая целина", 400, new Author("М.А.Шолохов"));

            Book[] books = { book1, book3, book4 };

            book2.Name.Name = "А.С.Пушкин";

            Console.WriteLine("Реализация ICloneable(глубокого копирование):");


            Console.WriteLine(book1.Name.Name);

            Console.WriteLine("-----------------------");

            var new_papers1 = new News_paper("Правда", 80);

            var new_papers2 = new News_paper("Ведомости", 94);

            var new_papers3 = new News_paper("Комсомолец", 72);

            News_paper[] newspapers = { new_papers1, new_papers2, new_papers3 };

            Array.Sort(newspapers);

            Console.WriteLine("Реализация IComparable:");


            foreach (News_paper news_Paper in newspapers)
            {

                Console.WriteLine($"{news_Paper.Printed_edition1} - {news_Paper.Cost}");

            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Реализация IComparer:");

            Array.Sort(books, new BooksComparer());

            foreach (Book bOOk in books)
            {

                Console.WriteLine($"{bOOk.Printed_edition1} - {bOOk.PapersCount}");

            }

            Console.WriteLine("-----------------------");

            Magazines magazineS = new Magazines();

            Console.WriteLine("Реализация IEnumerable:");


            foreach (var MagazineS in magazineS)
            {

                Console.WriteLine(MagazineS);

            }
        }
    }
}



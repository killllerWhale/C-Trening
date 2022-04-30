using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book : Item
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9; // стоимость аренды за любую книгу

        public Book()
        {
            // конструктор без параметров
        }

        public Book(String author, String title)
        {
            // конструктор с параметрами 

            this.author = author;
            this.title = title;
        }


        public Book(String author, String title, String publisher, int pages, int year)
        {
            // конструктор с параметрами 

            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)

        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        static Book() //статический конструктор
        {
            price = 10;
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void SetBook(String author, String title, String publisher, int pages, int year)

        {
            // метод, устанавливающий значения характеристик книги

            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            // метод устанавливающий стоимость аренды

            Book.price = price;
        }


        public double PriceBook(int s)
        {
            // метод расчета цены

            double cust = s * price;
            return cust;
        }

        public void Show()
        {
            Console.WriteLine("\nКнига: \nАвтор: " + author + "\nНазвание: " + title + "\nГод издания: " + year + "\nИздательство: " + publisher + "\n" +
                 pages + " стр.\nСтоимость аренды: " + Book.price);
            base.Show();
        }

        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true) taken = true;
            else taken = false;
        }

        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }
    }
}

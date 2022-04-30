using practice2;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Book : Item
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9; // стоимость аренды за любую книгу


        public Book(String author, String title, String publisher, int pages, int year,long invNumber, bool taken) : base(invNumber, taken)

        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }


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

        public void SetBook(String author, String title, String publisher,int pages, int year)

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

        new public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: { 2}\n Издательство: { 3}\n { 4}\n Стоимость аренды: { 5}", author, title, year, publisher, pages, Book.price);
            base.Show();
        }


        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }



        public double PriceBook(int s)
        {
            // метод расчета цены

            double cust = s * price;
            return cust;
        }

        public override void Return()
        {
            taken = true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Magazine : Item
    {
        private string volume; // том
        private int number; // номер
        private string title; // название
        private int year; // год выпуска

        public Magazine()
        { }

        public Magazine(string volume, int number, string title, int year,
        long invNumber, bool taken) : base(invNumber, taken)

        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        new public void Show()
        {
            Console.WriteLine("\nЖурнал:\n Том:" + volume + "\n Номер: " + number + "\n Название: " + title + "\n Год выпуска: " + year);
            base.Show();
        }

        public override void Return() // операция "вернуть"
        {
            taken = true;
        }
    }
}

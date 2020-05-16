﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Magazine: Item
    {
        public string Volume { get; set; } // том
        public int Number { get; set; } // номер
        public string Title { get; set; } // название
        public int Year { get; set; } // год выпуска
        public Magazine(string volume, int number, string title, int year,
                            long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }
        public Magazine() : base()
        { }
        new public void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }


        public override string ToString()
        {
            string bs = String.Format("\nЖурнал:\n Том: {0}\n Номер: {1}\n" +
                " Название: {2} \n Год выпуска: {3}", Volume, Number, Title, Year);
            return bs;
        }
        public override void Return() // операция "вернуть"
        {
            taken = true;
        }
    }
}

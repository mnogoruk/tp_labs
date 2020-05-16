﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    abstract class Item
    {
        public abstract void Return(); // операция "вернуть"


        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }

        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }


        // истина, если этот предмет имеется в библиотеке
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "взять"
        protected void Take()
        {
            taken = false;
        }
        // операция "вернуть"

        public void Print()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: " +
                "{0}\n Наличие: {1}", invNumber, taken);
        }
        
    }
}

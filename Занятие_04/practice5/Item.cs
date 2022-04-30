using System;
using System.Collections.Generic;
using System.Text;

namespace practice2
{
    abstract class Item : IComparable
    {
        protected long invNumber; // инвентарный номер – целое число
        protected bool taken; // хранит состояние объекта – имеется в библиотеке или нет, то есть взят на руки

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }

        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }

        public bool IsAvailable() // истина, если предмет имеется в библиотеке
        {
            if (taken == true) return true; else return false;
        }
        public long GetInvNumber() // инвентарный номер
        {
            return invNumber;
        }
        public void Take() // операция "взять"
        {
            taken = false;
        }
        abstract public void Return(); 

        public void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарныйномер: "+ invNumber + "\n Наличие: " + taken);
        }

       

    }
}

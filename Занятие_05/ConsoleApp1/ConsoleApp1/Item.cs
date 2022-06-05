using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Item
    {
        protected long invNumber; // инвентарный номер – целое число
        protected bool taken; // хранит состояние объекта – имеется в библиотеке или нет, то есть взят на руки
        protected bool returnSrok;

        public Item()
        {
            this.taken = true;
        }

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public virtual void Return() // операция "вернуть"
        {
            taken = true;
        }

        public void ReturnSrok()
        {
            returnSrok = true;
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


        public void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: " + invNumber + "\n Наличие: " + taken);

        }
    }
}

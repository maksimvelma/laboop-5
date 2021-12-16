using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab52
{
    interface IPrintable
    {
        void print();
    }
    class Book : IPrintable
    {
        public void print()
        {
            Console.WriteLine("Книга");
        }
    }
    class Magazine : IPrintable
    {
        public void print() 
        {
            Console.WriteLine("Магазин");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] pr = new IPrintable[6];
            pr[0] = new Book();
            pr[1] = new Magazine();
            pr[2] = new Book();
            pr[3] = new Magazine();
            pr[4] = new Book();
            pr[5] = new Magazine();
            foreach (var printable in pr)
            {
                printable.print();
            }
        }
    }
}

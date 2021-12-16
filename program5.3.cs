using System;

namespace _3
{
    class Shop
    {
        public string[] sizeClothes = { "XXS", "XS", "S", "M", "L" };
        public string euroSize;

        public Shop(string euroSize)
        {
            this.euroSize = euroSize;
        }

        public string GetSize
        {
            get
            {
                return euroSize;
            }
        }

        public string EuroSize
        {
            set
            {
                euroSize = value;
                if (euroSize == "32")
                {
                    euroSize = sizeClothes[0];
                }
                else if (euroSize == "34")
                {
                    euroSize = sizeClothes[1];
                }
                else if (euroSize == "36")
                {
                    euroSize = sizeClothes[2];
                }
                else if (euroSize == "38")
                {
                    euroSize = sizeClothes[3];
                }
                else if (euroSize == "40")
                {
                    euroSize = sizeClothes[4];
                }
            }
        }
        public void getDescription()
        {
            if (euroSize == sizeClothes[0])
            {
                Console.WriteLine("Дитячий розмiр");
            }
            else
            {
                Console.WriteLine("Дорослий розмiр");
            }
            Console.WriteLine();
        }
    }
    interface IMenswear
    {
        void dressMan();
    }

    interface IWomenswear
    {
        void dressWoman();
    }

    abstract class Clothes
    {
        protected int sizeClothes;
        protected double price;
        protected string color;
        protected Clothes(int s, double p, string c)
        {
            sizeClothes = s;
            price = p;
            color = c;
        }
    }

    class TShirt : Clothes, IMenswear, IWomenswear
    {
        public TShirt(int sizeClothes, double price, string color) : base(sizeClothes, price, color) { }
        public void dressMan()
        {
            Console.WriteLine("Футболка:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
        public void dressWoman()
        {
            Console.WriteLine("Футболка:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }

    class Pants : Clothes, IMenswear, IWomenswear
    {
        public Pants(int sizeClothes, double price, string color) : base(sizeClothes, price, color) { }
        public void dressMan()
        {
            Console.WriteLine("Штани:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
        public void dressWoman()
        {
            Console.WriteLine("Штани:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }

    class Skirt : Clothes, IWomenswear
    {
        public Skirt(int sizeClothes, double price, string color) : base(sizeClothes, price, color) { }
        public void dressWoman()
        {
            Console.WriteLine("Спiдниця:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }

    class Necktie : Clothes, IMenswear
    {
        public Necktie(int sizeClothes, double price, string color) : base(sizeClothes, price, color) { }
        public void dressMan()
        {
            Console.WriteLine("Краватка:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }

    class Atelier
    {
        public void dressMan()
        {
            Console.WriteLine("Одягаю чоловiка");
            IMenswear[] wear = { new TShirt(38, 325.50, "бiлий"), new Pants(43, 725.99, "чорний"), new Necktie(8, 90.45, "чорний") };
            foreach (IMenswear men in wear)
            {
                men.dressMan();
            }
            Console.WriteLine();
        }
        public void dressWoman()
        {
            Console.WriteLine("Одягаю жiнку: ");
            IWomenswear[] wear = { new TShirt(35, 336.10, "оранжевий"), new Pants(38, 825.15, "бiлий"), new Skirt(6, 85.99, "бiлий") };
            foreach (IWomenswear women in wear)
            {
                women.dressWoman();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть розмiр (32, 34, 36, 38, 40): ");
            string size = Console.ReadLine();
            var shop = new Shop(size);
            shop.EuroSize = shop.GetSize;
            shop.getDescription();
            var atelier = new Atelier();
            atelier.dressMan();
            atelier.dressWoman();
        }
    }
}
}

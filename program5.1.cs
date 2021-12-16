using System;

namespace lab5-1
{
    interface IShape
    {
        string sizeFigure { get; }
        string Type();
        string Square();
    }
    interface IColoredShape : IShape
    {
        string color { set; }
        string ShowColor();
    }
    class Circle : IShape
    {
        protected double r { get; set; }
        public Circle(double r)
        {
            this.r = r;
        }
        public string sizeFigure
        {
            get
            {
                return $"Розмiр фiгури: {r}";
            }
        }
        public string Square()
        {
            double s = Math.PI*(r*r);
            return $"Площа фiгури = {s.ToString("F" + 5)}";
        }
        public string Type()
        {
            return "Тип: коло";
        }
    }
    class ColoredCircle : Circle, IColoredShape
    {
        public string color;
        public ColoredCircle(double r, string color) : base (r)
        {
            this.color = color;
        }

        string IColoredShape.color { set => Console.ReadLine(); }

        public string ShowColor()
        {
            return $"Колiр: {color}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ColoredCircle[] rectangle = { new ColoredCircle (2.75,"чорний"), new ColoredCircle (6.25,"бiлий"), new ColoredCircle (7.5,"жовтий") };
            foreach (ColoredCircle str in rectangle)
            {
                Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Square()}\n{str.ShowColor()}\n");
            }
        }
    }
}

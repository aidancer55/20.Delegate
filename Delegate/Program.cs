using System;

namespace Delegate
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Length;
            myDelegate += Square;
            myDelegate += Volume;
            myDelegate(10);
            Console.ReadKey();
        }
        static double Length(double r)
        {
            Console.WriteLine("Длина окружности");
            double l = Math.Round(2 * Math.PI * r, 1);
            Console.WriteLine(l); 
            Console.WriteLine();
            return l;
        }
        static double Square(double r)
        {
            Console.WriteLine("Площадь круга");
            double s = Math.Round(Math.PI * Math.Pow(r, 2), 1);
            Console.WriteLine(s);
            Console.WriteLine();
            return s;
        }
        static double Volume(double r)
        {
            Console.WriteLine("Объем шара");
            double v = Math.Round(4 / 3 * Math.PI * Math.Pow(r, 3), 1);
            Console.WriteLine(v);
            return v;
        }

    }
}

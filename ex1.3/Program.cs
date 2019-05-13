using System;

namespace ex1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value1");
            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value2");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value3");
            double value3 = double.Parse(Console.ReadLine());

            double E = HeronFormula(value1, value2, value3);
            Console.WriteLine("The solution is {0}:", E);
        }
        static double HeronFormula(double value1, double value2, double value3)
        {


            double sp;
            double t;
            double E;
            t = (value1 + value2 + value3) / 2;
            E = Math.Sqrt(t * (t - value1) - (t - value2) * (t - value3));

            return E;
            
        }

    }

}

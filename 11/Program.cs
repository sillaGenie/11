using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0=kx+b");
            Console.Write("b=");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("k=");
            double k = Convert.ToInt32(Console.ReadLine());
            Equation equation = new Equation();
            
    
            Console.WriteLine("x={0}", equation.Root(b, k));
        }
        
    }
    struct Equation
    {
        public double k;
        public double b;
        public Equation(double b, double k)
        {
            this.b = b;
            this.k = k;
        }
        public double Root(double b, double k)
        {
            return -b / k;
        }
    }
}
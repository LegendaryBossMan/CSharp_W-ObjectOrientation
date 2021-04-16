using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment1
{
    class RightTriangle
    {
        private double a;
        private double b;
        private double c;

        public void seta(double len)
        {
            a = len;
        }//end lenght

        public void setb(double hei)
        {
            b = hei;
        }

        public void setc(double wid)
        {
            c = wid;
        }
        public double getC(double a, double b)
        {
            double c;
           return c = (a * a) + (b * b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle Tri1 = new RightTriangle();
            double volume = 0;
            double a;
            double b;
            Console.WriteLine("enter what A square is");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter what B square is");
            b = Convert.ToDouble(Console.ReadLine());
            volume = Tri1.getC(a, b);
            

            Console.WriteLine("The Volume of the RightTriangle is {0}", volume);
            Console.ReadKey();
        }//end main
    }//end program
}//end namespace

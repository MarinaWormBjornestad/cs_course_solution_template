using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statiske_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,10));
            Console.ReadKey();
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
            Console.ReadKey();
        }
    }

    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double h, double b)
        {
            return h * b;
        }
        public static double BeregnArealCirkel(double r)
        {
            return Math.Pow(r, 2) * System.Math.PI;
        }       
    }
}

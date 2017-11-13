using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            //Console.ReadKey();

            Udskriv(); // blank linje

            Udskriv("Dette er en test"); //dette er en test

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3); // 25.0875

            //optional parameter
            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res4); //25.0875
            //Console.ReadKey();

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns); // 15.000

        }

        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            return sum / månedsløn.Length;
        }

        static double BeregnMoms(double tal, double momsPct = 0.25)
        {
            return tal * momsPct;
        }
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return (radius * radius) * 3.1415;
        }

        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }
        static void Udskriv()
        {
            Console.WriteLine();
        }
    }
}
    
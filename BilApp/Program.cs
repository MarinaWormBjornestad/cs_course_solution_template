using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilApp
{
    class Program
    {
        static void Main(string[] args)   
        {
            Bil b = new Bil();
            b.BilId = 1;
            b.Model = "X";
            b.AntalCylindre = 4;

            Console.WriteLine("Ny bil");
            Console.ReadKey();

            LastBil a = new LastBil();
            a.BilId = 2;
            a.Model = "Y";
            a.AntalCylindre = 8;

            b.Print();
            a.Print();

            Console.ReadKey();

        }
    }
}

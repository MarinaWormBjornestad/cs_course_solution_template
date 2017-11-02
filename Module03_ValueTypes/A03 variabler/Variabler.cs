
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            Filtyper ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("d-M-y"));
            Console.WriteLine(dato.ToLongDateString());

            Person p;
            p.id = 1;
            p.navn = "Marina";
            Console.WriteLine(p.navn);
        }
    }
    public struct Person
    {
        public int id;
        public string navn;
    }
    public enum Filtyper
    {
        pdf,
        txt,
        csv
    }
}

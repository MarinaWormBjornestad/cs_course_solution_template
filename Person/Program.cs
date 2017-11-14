using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "X", Fornavn = "y" };
            Elev e = new Elev() { Efternavn = "t", Fornavn = "g", KlasseLokale = "A" };
            Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleId = 1 };

            Console.WriteLine(p.FuldtNavn());
            System.Console.ReadKey();

            Console.WriteLine(e.FuldtNavn());
            System.Console.ReadKey();

            Console.WriteLine(i.FuldtNavn());
            System.Console.ReadKey();
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn ()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }

    public class Elev : Person
    {
        public string KlasseLokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}

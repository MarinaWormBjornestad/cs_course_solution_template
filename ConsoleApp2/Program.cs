using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "bjørnestad";
            p1.Fornavn = "marina";
            p1.Fødselsår = 1967;

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        //default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        // custom constructor
        public Person(string efternavn, string fornavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();
        }

    }
}

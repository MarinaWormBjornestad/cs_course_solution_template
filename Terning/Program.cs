using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    public class Terning
    {
        private static Random rnd = new Random();
        public int værdi;
        private bool snyd;

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);

        }
    }
}

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning T1 = new Terning();
            T1.Skriv();
            Console.ReadKey();
            T1.Ryst();
            T1.Skriv();
           

            Terning T2 = new Terning(true);
            T2.Skriv();
            Console.ReadKey();
            T2.Ryst();
            T2.Skriv();
            Console.ReadKey();
        }
    }
}


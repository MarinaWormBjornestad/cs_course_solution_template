using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreKant
{
    public class TreKant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public TreKant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                Console.WriteLine("Grundlinje: ");
                Console.ReadKey();
                return this.Grundlinje * this.Højde * 0.5;
            }
        }
        
   
   
   
        static void Main(string[] args)
        {
            TreKant TK = new TreKant(10,5);  
            
        Console.WriteLine($"Grundlinje: {TK.Grundlinje}");
        Console.ReadKey();

        Console.WriteLine($"Højde: {TK.Højde}");
            Console.ReadKey();
        }

    }
   
}

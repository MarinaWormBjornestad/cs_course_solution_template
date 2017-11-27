using System;

namespace BilApp
{
    public class Bil
    {

        //public int BilId;
        public int BilId { get; set; }
        public string Model { get; set; }

        //public int AntalCylindre { get; set; }

        private int antalCylindre;

        public int AntalCylindre    
        {
            get { return AntalCylindre; }
            set {
                if (value < 4 || value > 8)
                    throw new ApplicationException("Forkert antal cylindre");   

               
            }
        }

        public void Print()
        {
            Console.WriteLine("Bil :" + this.Model);
        }

    }

    public class PersonBil : Bil {
        public int AntalBarnesæder { get; set; }
    }

    public class LastBil : Bil {
        public int LasteEvne { get; set; }
    }
}

 
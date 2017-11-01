namespace Module03_ValueTypes
{
    using System;
    
    class Program    { 
        

        static void Main(string[] args)
        {
            /*new Person("P");
            Person.navn = "Søren";
            Person.alder = "29";*/
         

            DateTime d = DateTime.now;
            DateTime m = new DateTime(2017,12,24);
            TimeSpan t = m.subtract(d);
            Console.WriteLine(t.TotalDays);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            } 
        }
        //værdibaseret klasse struct  - på stack
       /* struct Person { 
                            public string navn;
                            public int alder;
                            public string adresse;
                          } */


        //Char er omkranset af '' altså enkeltstrenge 

    }
}

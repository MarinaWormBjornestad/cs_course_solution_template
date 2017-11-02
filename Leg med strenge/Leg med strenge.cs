using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leg_med_strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Marina";
            string efternavn = "Bjørnestad";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            Console.WriteLine("         ");
            Console.WriteLine("Fornavn: ");
            string del1 = samletNavn.Substring(0,6);
            Console.WriteLine(del1);

            Console.WriteLine("         ");
            Console.WriteLine("Efternavn: ");
            string del2 = samletNavn.Substring(7, 10);
            Console.WriteLine(del2);

            Console.WriteLine("         ");
            string[] navne = samletNavn.Split(' ');
            for (int i = 0; i < navne.Length; i++)
                Console.WriteLine(navne[i]);

           
            Console.WriteLine(fornavn + "\r\n\t" + efternavn);      

            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);

            Console.ReadKey();


            /*\\\\\\*/



        }
    }
}

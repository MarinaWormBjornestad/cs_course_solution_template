﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_contra_struct
{
    class Program
    {
        static void Main(string[] args)
        {

            Person k1 = new Person();
            k1.navn = "a";

            Person k2 = new Person();
            k2.navn = "b";

            Console.WriteLine("k1.navn: " + k1.navn);
            Console.WriteLine("k2.navn: " + k2.navn);
            Console.WriteLine("                  " );


            k1 = k2;
            Console.WriteLine("Hvis vi sætter k1 = k2: ");
            Console.WriteLine("k1.navn: " + k1.navn);
            Console.WriteLine("k2.navn: " + k2.navn);
            Console.WriteLine("                  ");


            k1.navn = "c";
            Console.WriteLine("Hvis vi sætter k1.navn = 'c' ");
            Console.WriteLine("k1.navn: " + k1.navn);
            Console.WriteLine("k2.navn: " + k2.navn);
            Console.WriteLine("                  ");

            Console.ReadKey();
        }
    }
    struct Person
    {
        public string navn;
    }

    /*class Person
    {
        public string navn;
    } */
}

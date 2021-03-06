﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    { 

        public delegate int BeregnDelegate(int a, int b);
    
        static void Main(string[] args)
        {
            int res = Beregner(1, 1, Plus);   

            Console.WriteLine(value: res);
            Console.ReadKey();

            res = Beregner(5, 2, Minus);
            Console.WriteLine(value: res);
            Console.ReadKey();

            res = Beregner(2, 2, Gange);
            Console.WriteLine(value: res);
            Console.ReadKey();

            res = Beregner(10, 5, Divider);
            Console.WriteLine(value: res);
            Console.ReadKey();  
        }

        public static int Beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);           
        }

        public static int Plus(int a, int b)
        {
            return (a + b);
        }

        public static int Minus(int a, int b)
        {
            return (a - b);
        }

        public static int Divider(int a, int b)
        {
            return (a / b);
        }

        public static int Gange(int a, int b)
        {
            return (a * b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)
                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                    { 
                          
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    else
                        if ((xx * yy) > 25)
                    { 
                        Console.BackgroundColor = ConsoleColor.White ;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                        if ((xx * yy) > 7)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                    else
                    { 
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(tal.PadLeft(4));

                }
                Console.WriteLine();

                Console.ReadKey();  

            }

        }
    }
}

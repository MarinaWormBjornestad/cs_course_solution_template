using System;
using System.IO;

namespace Using
{
    class Program 
    
    {
        static void Main(string[] args)
        {

            using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt")) 
              while (stream.Peek() != -1)
               {
                var l = stream.ReadLine();
                Console.WriteLine(l.ToUpper());

                    Console.ReadKey(); 
                }

           // stream.Close();
           // stream = null;

        }
    }


}
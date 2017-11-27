using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunke
{
    class Person
    {
        static void Main(string[] args)
        {
            List<Person> lst1 = new List<Person>();
            lst1.Add(new Person() { Id = 1, Navn = "M" });
            lst1.Add(new Person() { Id = 2, Navn = "T" });
            lst1.Add(new Person() { Id = 3, Navn = "P" });
            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
                Console.ReadKey();
            }

        }

        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
